using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaUtterson : MonoBehaviour
{
    [SerializeField] GameObject caneblood, topmarking, bottommarking, notesTitle, notesTotalFailure, notesDouble, notesSalt, solvethecase;
    [SerializeField] GameObject cbMissing, tmMissing, bmMissing, ntMissing, ntfMissing, ndMissing, nsMissing;
    private void OnEnable()
    {
        if (AlphaClueManager.caneBlood == true)
        {
            caneblood.SetActive(true);
            cbMissing.SetActive(false);
        }
        if (AlphaClueManager.topMarking == true)
        {
            topmarking.SetActive(true);
            tmMissing.SetActive(false);
        }
        if(AlphaClueManager.bottomMarking == true)
        {
            bottommarking.SetActive(true);
            bmMissing.SetActive(false);
        }
        if(AlphaClueManager.notesTitle == true)
        {
            notesTitle.SetActive(true);
            ntMissing.SetActive(false);
        }
        if(AlphaClueManager.notesTotalFailure == true)
        {
            notesTotalFailure.SetActive(true);
            ntfMissing.SetActive(false);
        }
        if(AlphaClueManager.notesDouble == true)
        {
            notesDouble.SetActive(true);
            ndMissing.SetActive(false);
        }
        if(AlphaClueManager.notesSalt == true)
        {
            notesSalt.SetActive(true);
            nsMissing.SetActive(false);
        }
        if(AlphaClueManager.totalClues >= 7)
        {
            solvethecase.SetActive(true);
        }
    }
}
