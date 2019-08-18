using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSessionCurrentLevel : MonoBehaviour {

    //This Script counts current score on each level and has not a Singleton Pattern.

    [SerializeField] TextMeshProUGUI currentScoreText;
    [SerializeField] int currentScore = 0;

    int totalBlocks;

    private void Start()
    {
            //totalBlocks = GameObject.FindObjectsOfType(typeof(Block)).Length;
            totalBlocks = GameObject.FindGameObjectsWithTag("Breakable").Length;
        currentScoreText.text = "Current: " + currentScore.ToString() + "/" + totalBlocks.ToString();
    }

    public void AddToScore()
    {
        currentScore += 1;
        currentScoreText.text = "Current: " + currentScore.ToString() + "/" + totalBlocks.ToString();
    }
}
