using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueButtonScript : MonoBehaviour
{
    [SerializeField] private bool alreadyClicked = false;
    [SerializeField] private ClueManager cm;
    void Start()
    {
        alreadyClicked = false;
    }

    // Update is called once per frame
    public void buttonClicked()
    {
        if (!alreadyClicked)
        {
            cm.CollectClue();
            alreadyClicked = true;
        }
        else
        {
            return;
        }
    }
}
