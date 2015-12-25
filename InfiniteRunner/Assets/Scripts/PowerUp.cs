using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour
{

    public float objectspeed = 0.5f;
    //public float objectSpeed = -20f;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.timeScale == 1)
        {
            transform.Translate(0, 0, objectspeed);
        }

        //transform.Translate(new Vector3(0, 0, objectSpeed) * Time.deltaTime);
    }
}
