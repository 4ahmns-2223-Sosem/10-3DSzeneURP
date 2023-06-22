using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBottle3 : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        if (collectSound != null)
        {
            collectSound.Play();
        }
        ScoringSystem.theScore += 5;
        gameObject.SetActive(false);
    }
}