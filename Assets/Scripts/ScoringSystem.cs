using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    public TMP_Text scoreText;
    public static int theScore;
    public TMP_Text yourScoreText;
    public static int yourScore;



    void Update()
    {
        scoreText.GetComponent<TMP_Text>().text = "SCORE: " + theScore;
        yourScoreText.GetComponent<TMP_Text>().text = "Your Score: " + theScore;
    }
}
