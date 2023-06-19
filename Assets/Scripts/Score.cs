using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text scoreText;
    public Text panelHighScoreText;
    public Text panelScoreText;

    public GameObject New;
    private int highScore;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;


        scoreText= GetComponent<Text>();
        scoreText.text = score.ToString();
        panelScoreText.text = score.ToString();


        highScore = PlayerPrefs.GetInt("highscore");
        panelHighScoreText.text = highScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scored()
    {
        score++;
        scoreText.text = score.ToString();
        panelScoreText.text = score.ToString();

        if (score > highScore)
        {
            highScore = score;
            panelScoreText.text = highScore.ToString();
            PlayerPrefs.SetInt("highscore",highScore);
            New.SetActive(true);
        }
    }
}
