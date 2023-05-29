using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour
{

    private Rigidbody2D rbFish;
    [SerializeField]private float speed;
    int angle;
    int maxAngle = 20;
    int minAngle = -60;
    public Score score;
    // Start is called before the first frame update
    void Start()
    {
        rbFish = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rbFish.velocity = new Vector2(rbFish.velocity.x, speed);
        }
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            score.Scored();
        }
    }
}
