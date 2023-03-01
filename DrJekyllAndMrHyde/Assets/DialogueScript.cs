using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueScript : MonoBehaviour
{
    [SerializeField] GameObject[] lines;
    int linesIndex = 0;

    public void ProgressDialogue()
    {
        lines[linesIndex].SetActive(false);
        linesIndex++;
        lines[linesIndex].SetActive(true);
    }
}
