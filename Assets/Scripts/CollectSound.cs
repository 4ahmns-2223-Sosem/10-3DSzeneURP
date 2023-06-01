using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSound : MonoBehaviour
{
    public AudioSource sound;
    private int currentScore;

    void Start()
    {
        currentScore = ScoringSystem.theScore;
    }

    void Update()
    {
        if (ScoringSystem.theScore != currentScore)
        {
            sound.Play();
            currentScore = ScoringSystem.theScore;
        }
    }
}
