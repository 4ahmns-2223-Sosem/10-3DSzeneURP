using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 60;
    public bool takingAway = false;
    public GameObject Winscreen;
    public GameObject GameScreen;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = "01:00 ";
    }

    void Update()
    {
        if(takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        

        if (secondsLeft == (0))
        {
            Debug.Log("WinScreen");
            Winscreen.SetActive(true);
            GameScreen.SetActive(false);
        }
        else
        {
            Winscreen.SetActive(false);
            GameScreen.SetActive(true);
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<Text>().text = "00: " + secondsLeft;
        takingAway = false;

    }
}
