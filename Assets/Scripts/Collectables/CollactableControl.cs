using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollactableControl : MonoBehaviour
{
    public static int markCount;
    public GameObject markCountDisplay;
    public GameObject coinEndDisplay;

    void Update()
    {
        markCountDisplay.GetComponent<Text>().text = "" + markCount;
        coinEndDisplay.GetComponent<Text>().text = "" + markCount;
    }
}
