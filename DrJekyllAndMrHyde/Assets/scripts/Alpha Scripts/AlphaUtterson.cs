using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaUtterson : MonoBehaviour
{
    [SerializeField] GameObject caneblood, topmarking, bottommarking, notesTitle, notesTotalFailure, notesDouble, notesSalt, solvethecase;
    private void OnEnable()
    {
        if (AlphaClueManager.caneBlood == true)
        {
            caneblood.SetActive(true);
        }
        if (AlphaClueManager.topMarking == true)
        {
            topmarking.SetActive(true);
        }
        if(AlphaClueManager.bottomMarking == true)
        {
            bottommarking.SetActive(true);
        }
        if(AlphaClueManager.notesTitle == true)
        {
            notesTitle.SetActive(true);
        }
        if(AlphaClueManager.notesTotalFailure == true)
        {
            notesTotalFailure.SetActive(true);
        }
        if(AlphaClueManager.notesDouble == true)
        {
            notesDouble.SetActive(true);
        }
        if(AlphaClueManager.notesSalt == true)
        {
            notesSalt.SetActive(true);
        }
        if(AlphaClueManager.totalClues >= 7)
        {
            solvethecase.SetActive(true);
        }
    }
}
