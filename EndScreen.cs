using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class EndScreen : MonoBehaviour

{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;
    void Awake()
    {
        scoreKeeper = FindAnyObjectByType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulations!\nYou got a score of " + scoreKeeper.CalculateScore() + "%";
    }


}
