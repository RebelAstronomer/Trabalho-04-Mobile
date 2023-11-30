using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class CollectableController : MonoBehaviour
{
    public static int coinCount;
    public TextMeshProUGUI coinCountDisplay;
    public TextMeshProUGUI coinEndCountDisplay;

    void Update()
    {
        coinCountDisplay.text = coinCount.ToString();
        coinEndCountDisplay.text = coinCount.ToString();
    }
}
