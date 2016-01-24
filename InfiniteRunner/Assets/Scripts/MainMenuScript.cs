using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour 
{
	public GUISkin myskin;
	public string gamelevel;
	public string optionsLevel;
	public Animator animator;

	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	private void OnGUI()
	{
		GUI.skin = myskin;

		GUI.Box(new Rect(Screen.width/4, Screen.height/4, Screen.width/2, Screen.height/2), "MAIN MENU");

		if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+Screen.height/10+10, Screen.width/2-20, Screen.height/10), "PLAY"))
		{
			Application.LoadLevel(gamelevel);
		}

		if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+2*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "CREDITS"))
		{
			Application.LoadLevel(optionsLevel);
		}

		if (GUI.Button(new Rect(Screen.width/4+10, Screen.height/4+3*Screen.height/10+10, Screen.width/2-20, Screen.height/10), "EXIT"))
		{
			Application.Quit();
		}
	}
}
