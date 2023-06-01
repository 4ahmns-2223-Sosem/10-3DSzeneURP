using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Counter : MonoBehaviour
{
    public TMP_Text textDisplay;
    public int secondsLeft = 60;
    public bool takingAway = false;
    public GameObject Winscreen;
    public GameObject GameScreen;
    public float winScreenDuration = 5f;
    private float winScreenTimer = 0f;
    private bool showWinScreen = false;
    public GameObject Gamemanager;

    void Start()
    {
        textDisplay.GetComponent<TMP_Text>().text = "TIME: 150 ";
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if (secondsLeft == 0)
        {
            if (!showWinScreen)
            {
                showWinScreen = true;
                winScreenTimer = 0f;
                Winscreen.SetActive(true);
                GameScreen.SetActive(false);
                Gamemanager.GetComponent<ScoringSystem>().enabled = false;
            }
        }
        else
        {
            showWinScreen = false;
            Winscreen.SetActive(false);
            GameScreen.SetActive(true);
        }

        if (showWinScreen)
        {
            winScreenTimer += Time.deltaTime;
            if (winScreenTimer >= winScreenDuration)
            {
                SceneManager.LoadScene("TestScene");
            }
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textDisplay.GetComponent<TMP_Text>().text = "TIME: " + secondsLeft;
        takingAway = false;
    }
}