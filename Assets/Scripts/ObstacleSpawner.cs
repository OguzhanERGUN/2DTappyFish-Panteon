using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstacle;
    private float timer;
    public float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;

        if (timer >= maxTime)
        {

            InstantiateObstacle();

        }

    }

    private void InstantiateObstacle()
    {
        Instantiate(obstacle, transform.position, obstacle.transform.rotation);
    }

}
