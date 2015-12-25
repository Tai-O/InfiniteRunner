using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
    public float objectSpeed = 0.5f;
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
            transform.Translate(0, objectSpeed, 0);
        }

        //transform.Translate(new Vector3(0, objectSpeed, 0) * Time.deltaTime);
    }
}
