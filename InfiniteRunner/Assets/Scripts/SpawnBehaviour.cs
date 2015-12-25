using UnityEngine;
using System.Collections;

public class SpawnBehaviour : MonoBehaviour
{

    public GameObject obstacle;
    public GameObject powerup;

    float timeElapsed = 0;
    float spawnCycle = 0.5f;
    bool spawnchecker = true;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeElapsed += Time.deltaTime;

        if(timeElapsed > spawnCycle)
        {
            GameObject temp;
            if (spawnchecker)
            {
                temp = Instantiate(powerup);
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(Random.Range(-3f, 4f), 0.29f, 32.73079f);
            }
            else
            {
                temp = Instantiate(obstacle);
                Vector3 pos = temp.transform.position;
                temp.transform.position = new Vector3(Random.Range(-3f, 4f), 1.1f, 29.09092f);
            }

            timeElapsed -= spawnCycle;
            spawnchecker = !spawnchecker;
        }

	}
}
