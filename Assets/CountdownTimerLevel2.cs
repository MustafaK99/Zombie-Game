using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimerLevel2 : MonoBehaviour
{
    public float timeRemaining = 300;
    public bool timerIsRunning = false;
    public Text timeText;
    public Text levelComplete;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);

                if (GameObject.FindGameObjectsWithTag("Zombie").Length == 0)
                {
                    Debug.Log("Level Complete");
                    timeText.text = string.Format(" ");
                    levelComplete.text = string.Format("Level Complete");
                    StartCoroutine(Delay());
                   

                }



            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }




    IEnumerator Delay()
    {
        yield return new WaitForSeconds(5);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(0);
    }


    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}