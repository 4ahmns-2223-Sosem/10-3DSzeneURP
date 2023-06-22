using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBottle : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        if (collectSound != null)
        {
            collectSound.Play();
        }
        ScoringSystem.theScore += 1;
        gameObject.SetActive(false);
    }
}