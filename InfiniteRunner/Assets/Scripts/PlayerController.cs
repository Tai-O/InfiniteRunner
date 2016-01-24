using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    int jumpHash = Animator.StringToHash("Jumping");
    int BackToRunningHash = Animator.StringToHash("BackToRunning");
    private Vector3 moveDirection = Vector3.zero;
    public float speed = 3.0f;
    public GameControl control;
	public bool moving;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
		moving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger(jumpHash);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetTrigger(BackToRunningHash);
        }
		else if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x <= 4.5 && moving)
        {
            float goleft = transform.position.x + 0.1f * speed;
            if (goleft > 4.5)
            {
                transform.position = new Vector3(4.5f, 0.25f, 39.25486f);
            }
            else
            {
                transform.position = new Vector3(goleft, 0.25f, 39.25486f);
            }
            moveDirection = transform.position;
            moveDirection = transform.TransformDirection(moveDirection);
        }
		else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x >=-4.5 && moving)
        {
            float goright = transform.position.x - 0.1f * speed;
            if (goright < -4.5)
            {
                transform.position = new Vector3(-4.5f, 0.25f, 39.25486f);
            }
            else
            {
                transform.position = new Vector3(goright, 0.25f, 39.25486f);
            }
            moveDirection = transform.position;
            moveDirection = transform.TransformDirection(moveDirection);
        }
     }

    void onTrigerEnter(Collider other)
    {
       if (other.gameObject.name == "Powerup(Clone)")
        {
            control.PowerUpCollected();
        }
       else if (other.gameObject.name == "Obstacle(Clone)")
        {
            control.ObstacleCollected();
        }
        Destroy(other.gameObject);
    }
}