using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private TMP_Text scoreText;
    public int score;
    public float timer;

    public TMP_Text ScoreText { get => scoreText; set => scoreText = value; }

    void Update()
    {
        UpdateScore();
    }


    public void UpdateScore()
    {
        int scorePerSeconds = 10;
        timer += Time.deltaTime;
        score = (int)(timer * scorePerSeconds);
        ScoreText.text = string.Format("{0:00000}", score);

    }
}