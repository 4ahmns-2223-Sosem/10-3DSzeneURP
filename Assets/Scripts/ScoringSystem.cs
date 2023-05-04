using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
    public GameObject yourScoreText;
    public static int yourScore;



    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE: " + theScore;
        yourScoreText.GetComponent<Text>().text = "Your Score: " + theScore;
    }
}
