using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    private float timer;
    public float maxTime;
    public float minY;
    public float maxY;
    float RandomY;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.IsgameOver == false && GameManager.IsgameStarted)
        {
            timer += Time.deltaTime;

            if (timer >= maxTime)
            {
                InstantiateObstacle();
                timer = 0;
            }
        }
    }

    public void InstantiateObstacle()
    {
        RandomY = Random.Range(minY, maxY);
        Instantiate(obstacle, new Vector2(transform.position.x, RandomY), obstacle.transform.rotation);
    }

}
