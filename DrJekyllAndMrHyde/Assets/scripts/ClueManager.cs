using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ClueManager : MonoBehaviour
{
    [SerializeField] private int cluesCollected;
    [SerializeField] private int totalClues = 5;
    [SerializeField] private TextMeshProUGUI tracker;
    [SerializeField] private GameObject continueButton;

    // Start is called before the first frame update
    void Start()
    {
        cluesCollected = 0;
        continueButton.SetActive(false);
    }

    // Update is called once per frame
    public void CollectClue()
    {
        cluesCollected += 1;
        tracker.text = cluesCollected.ToString();
        if (cluesCollected >= totalClues)
        {
            continueButton.SetActive(true);
        }
    }

    public void GoToEnd()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
