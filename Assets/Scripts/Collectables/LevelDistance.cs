using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public int gpaScore;
    public bool addingDis = false;
    public float disDelay = 0.75f;
    

    void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        gpaScore += 1;
        disDisplay.GetComponent<Text>().text = "" + gpaScore;
        disEndDisplay.GetComponent<Text>().text = "" + gpaScore;
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}
