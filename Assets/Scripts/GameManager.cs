using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static Vector2 bottomLeft;
    public static bool IsgameOver;
    public GameObject gameOverPanel;
    public static bool IsgameStarted;
    public GameObject getReadyImage;
    private void Awake()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        IsgameOver = false;


    }
    // Start is called before the first frame update
    void Start()
    {
        IsgameStarted = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        IsgameOver = true;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void GameHasStarted()
    {
        IsgameStarted=true;
        getReadyImage.SetActive(false);
    }
}
