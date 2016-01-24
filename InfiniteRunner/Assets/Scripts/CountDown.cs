using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour 
{
	public GameObject character;
	public GameObject wall1;
	public GameObject wall2;
	public GameObject ground;
	public int countMax;
	public int countDown;
	public GUIText guiTextCountdown;

	// Use this for initialization
	void Start () 
	{
		//Get all the scripts
		MonoBehaviour[] scriptComponentsGameControl = gameObject.GetComponents<MonoBehaviour> ();

		//loop through all the scripts and disable them from the start
		foreach (MonoBehaviour script in scriptComponentsGameControl) 
		{
			script.enabled = false;
		}
			
		//disable all the scripts attached to the walls, ground. Also disable the animation of character
		wall1.GetComponent<GroundControl>().enabled = false;
		wall2.GetComponent<GroundControl>().enabled = false;
		ground.GetComponent<GroundControl>().enabled = false;
		character.GetComponent<Animation>().enabled = false;

		StartCoroutine (CountdownFunction ());
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}



	IEnumerator CountdownFunction()
	{
		//start the countdown
		for (countDown = countMax; countDown > -1; countDown--) {
			if (countDown != 0) 
			{
				//display the number to the screen via the GUIText
				guiTextCountdown.text = countDown.ToString ();
				//add a one second delay
				yield return new WaitForSeconds (1);    
			} 
			else 
			{
				guiTextCountdown.text = "GO!";
				yield return new WaitForSeconds (1);
			}
		}
		//enable all the scripts and animation once the count is down
		MonoBehaviour[] scriptComponentsGameControl = gameObject.GetComponents<MonoBehaviour> ();
		foreach (MonoBehaviour script in scriptComponentsGameControl) 
		{
			script.enabled = true;
		}
		//enable all the scripts attached to the walls, ground. Also disable the animation of character
		wall1.GetComponent<GroundControl>().enabled = true;
		wall2.GetComponent<GroundControl>().enabled = true;
		ground.GetComponent<GroundControl>().enabled = true;
		character.GetComponent<Animation>().enabled = true;
		guiTextCountdown.enabled = false;
	}

}
