using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBottle2 : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        if (collectSound != null)
        {
            collectSound.Play();
        }
        ScoringSystem.theScore += 3;
        gameObject.SetActive(false);
    }
}