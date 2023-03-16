using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailState : MonoBehaviour
{
    int missCount = 0;
    [SerializeField] int missTotal = 3;
    [SerializeField] int recoveryAmount = 1;

    private void Update()
    {
        if(missCount >= missTotal)
        {
            SceneManager.LoadScene("FailState");
        }
    }
    public void MissCountUp()
    {
        missCount++;
    }
    public void MissCountDown()
    {
        missCount -= recoveryAmount;
    }
}
