using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject[] counterText;
    public GameObject fadeIn;
    public AudioSource readyFX;
    public AudioSource goFX;
    public AudioSource music;


    void Start()
    {
        StartCoroutine(CountSequence());
        fadeIn.SetActive(true);
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.5f);
        counterText[0].SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        counterText[1].SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        counterText[2].SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        counterText[3].SetActive(true);
        goFX.Play();
        PlayerMove.canMove = true;
        yield return new WaitForSeconds(0.5f);
        music.Play();
    }

}
