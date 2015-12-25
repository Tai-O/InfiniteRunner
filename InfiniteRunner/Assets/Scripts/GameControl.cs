using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour
{

    float timeRemaining = 20;
    float timeDeduction = 2f;
    float timeExtension = 3f;
    float totaltimeElapsed = 0;
    float score = 0f;
    public bool isGameOver = false;
    public GUISkin skin;

    // Use this for initialization
    void Start ()
    {
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isGameOver)
            return;

        totaltimeElapsed += Time.deltaTime;
        score = totaltimeElapsed * 100;
        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0)
        {
            isGameOver = true;
        }
	}

    public void PowerUpCollected()
    {
        timeRemaining += timeExtension;
    }

    public void ObstacleCollected()
    {
        timeRemaining -= timeDeduction;
    }

    void OnGUI()
    {
        GUI.skin = skin;
        if (!isGameOver)
        {
            GUI.Label(new Rect(10, 10, Screen.width / 5, Screen.height / 6), "TIME LEFT: " + ((int)timeRemaining).ToString());
            GUI.Label(new Rect(Screen.width - (Screen.width / 6), 10, Screen.width / 6, Screen.height / 6), "SCORE: " + ((int)score).ToString());
        }
        else
        {
            Time.timeScale = 0;
            GUI.Box(new Rect(Screen.width/4, Screen.height/4, Screen.width/2, Screen.height/2), "GAME OVER\nYOUR SCORE: " + (int)score);

            //Restart the Game on click
            if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+ Screen.height/10+10, Screen.width/2-20, Screen.height/10), "RESTART"))
            {
                Application.LoadLevel(0);
            }

            //Load the main menu
            if (GUI.Button(new Rect(Screen.width / 4 + 10, Screen.height / 4 + 2 * Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "MAIN MENU"))
            {
                Application.LoadLevel(0);
            }

            //Quit the game
            if (GUI.Button(new Rect(Screen.width / 4 + 10, Screen.height / 4 + 3 * Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "EXIT GAME"))
            {
                Application.Quit();
            }
        }
    }
}
