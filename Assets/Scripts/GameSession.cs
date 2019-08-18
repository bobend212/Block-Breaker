using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour {

    //This script is responsible for counting total score for full game and has a Singleton Design Pattern in Awake method

    [SerializeField] [Range(0.1f, 2f)] float gameSpeed = 1f;
    [SerializeField] TextMeshProUGUI totalScoreText;
    [SerializeField] int totalScore = 0;
    [SerializeField] bool isAutoPlayEnabled;

    //Singleton
    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if(gameStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        totalScoreText.text = "Total score: " + totalScore;
    }

    void Update () {
        Time.timeScale = gameSpeed;
	}

    public void AddToScore()
    {
        totalScore += 1;
        totalScoreText.text = "Total score: " + totalScore;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }
}
