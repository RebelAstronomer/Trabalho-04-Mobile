using UnityEngine;

public class EndRunSequence : MonoBehaviour
{
    public GameObject livePointsDisplay;
    public GameObject endScreen;
    public GameObject fadeOut;
    public GameObject[] buttons;
    void Start()
    {
        livePointsDisplay.SetActive(false);
        endScreen.SetActive(true);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].SetActive(true);
        }
    }

}
