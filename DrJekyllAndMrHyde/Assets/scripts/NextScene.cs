using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void GoToClueHunt()
    {
        SceneManager.LoadScene("ClueHuntAlpha");
    }

    public void GoToEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }
}
