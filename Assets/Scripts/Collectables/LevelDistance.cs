using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelDistance : MonoBehaviour
{

    public TextMeshProUGUI distDisplay;
    public TextMeshProUGUI distEndDisplay;
    public int distRun;
    public bool addingDist = false;
    public static float distDelay = 0.35f;

    void Update()
    {
        if (addingDist == false)
        {
            addingDist = true;
            StartCoroutine(AddingDist());
        }
    }

    IEnumerator AddingDist()
    {
        distRun += 1;
        distDisplay.text = distRun.ToString();
        distEndDisplay.text = distRun.ToString();
        yield return new WaitForSeconds(distDelay);
        addingDist = false;
    }

}
