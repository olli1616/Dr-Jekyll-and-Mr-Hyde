using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaClueManager : MonoBehaviour
{
    //total clues found, used to trigger end screen when u collect them all
    public static int totalClues = 0;
    //bools for if you collected a certain piece of evidence or not
    public static bool caneBlood = false;
    public static bool topMarking = false;
    public static bool bottomMarking = false;
    public static bool notesTitle = false;
    public static bool notesTotalFailure = false;
    public static bool notesDouble = false;
    public static bool notesSalt = false;

    public void CaneBlood()
    {
        if (caneBlood == false)
        {
            AlphaClueManager.caneBlood = true;
            AlphaClueManager.totalClues += 1;
        } 
    }

    public void TopMarking()
    {
        if (topMarking == false)
        {
            AlphaClueManager.topMarking = true;
            AlphaClueManager.totalClues += 1;
        }
    }

    public void BottomMarking()
    {
        if (bottomMarking == false)
        {
            AlphaClueManager.bottomMarking = true;
            AlphaClueManager.totalClues += 1;
        }
    }

    public void NotesTitle()
    {
        if (notesTitle == false)
        {
            AlphaClueManager.notesTitle = true;
            AlphaClueManager.totalClues += 1;
        }
    }

    public void NotesTotalFailure()
    {
        if (notesTotalFailure == false)
        {
            AlphaClueManager.notesTotalFailure = true;
            AlphaClueManager.totalClues += 1;
        }
    }

    public void NotesDouble()
    {
        if (notesDouble == false)
        {
            AlphaClueManager.notesDouble = true;
            AlphaClueManager.totalClues += 1;
        }
    }

    public void NotesSalt()
    {
        if (notesSalt == false)
        {
            AlphaClueManager.notesSalt = true;
            AlphaClueManager.totalClues += 1;
        }
    }
}
