using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour
{
    public GUISkin myskin;
    public string LevelToLoad;
    public bool Paused = false;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (Paused)
            {
                Paused = false;
            }
            else
                Paused = true;
        }

        if (Paused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;

    }


    private void OnGUI()
    {
        GUI.skin = myskin;   //use the custom GUISkin

        if (Paused)
        {
            GUI.Box(new Rect(Screen.width / 4, Screen.height / 4, Screen.width / 2, Screen.height / 2), "PAUSED");
            if (GUI.Button(new Rect(Screen.width / 4 + 10, Screen.height / 4 + Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "RESUME"))
            {
                Paused = false;
            }

            if (GUI.Button(new Rect(Screen.width / 4 + 10, Screen.height / 4 + 2 * Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "RESTART"))
            {
                Application.LoadLevel(Application.loadedLevel);
            }

            if (GUI.Button(new Rect(Screen.width / 4 + 10, Screen.height / 4 + 3 * Screen.height / 10 + 10, Screen.width / 2 - 20, Screen.height / 10), "MAIN MENU"))
            {
                Application.LoadLevel(LevelToLoad);
            }
        }
    }
}