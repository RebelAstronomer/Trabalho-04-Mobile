using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFoundation : MonoBehaviour
{

    public GameObject fadeIn;
    public GameObject fadeOut;
    public AudioSource sfx;

    public void PlayGame()
    {
        sfx.Play();
        StartCoroutine(StartTransitionFadeOut());
    }

    public void ReturnMainMenu()
    {
        sfx.Play();
        StartCoroutine(StartTransitionFadeIn());
    }

    public void QuitGame()
    {
        sfx.Play();
        Application.Quit();
    }

    IEnumerator StartTransitionFadeIn()
    {
        if (fadeIn != null)
        {
            fadeIn.SetActive(true);
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator StartTransitionFadeOut()
    {
        if (fadeOut != null)
        {
            fadeOut.SetActive(true);
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(1);
        }
    }
}
