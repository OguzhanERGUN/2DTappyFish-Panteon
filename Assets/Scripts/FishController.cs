using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{

    private Rigidbody2D rbFish;
    [SerializeField] private float speed;
    int angle;
    int maxAngle = 20;
    int minAngle = -60;
    public Score score;
    public GameManager gameManager;
    public Sprite deadFish;
    private SpriteRenderer sp;
    private Animator animatorFish;
    public ObstacleSpawner obstacleSpawner;
    // Start is called before the first frame update
    void Start()
    {
        rbFish = GetComponent<Rigidbody2D>();
        rbFish.gravityScale = 0f;
        sp = GetComponent<SpriteRenderer>();
        animatorFish = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        FishSwim();
    }

    private void FixedUpdate()
    {
        FishRotation();

    }

    private void FishSwim()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.IsgameOver == false)
        {
            if (GameManager.IsgameStarted == false)
            {
                rbFish.gravityScale = 1f;
                gameManager.GameHasStarted();
            }


            rbFish.velocity = new Vector2(rbFish.velocity.x, speed);
        }
    }


    private void FishRotation()
    {
        if (GameManager.IsgameOver == false)
        {


            if (rbFish.velocity.y >= 0)
            {
                if (angle <= maxAngle)
                {
                    angle = angle + 4;
                }
            }
            else if (rbFish.velocity.y < -2.5f)
            {
                if (angle >= minAngle)
                {
                    angle = angle - 2;
                }
            }
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            score.Scored();
        }
        else if (collision.CompareTag("Column"))
        {
            gameManager.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (GameManager.IsgameOver == false)
            {
                gameManager.GameOver();
                GameOver();
            }
            else
            {
               

            }
        }
    }

    void GameOver()
    {
        sp.sprite = deadFish;
        animatorFish.enabled = false;
        transform.rotation = Quaternion.Euler(0, 0, -90);
    }
}
