using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText= GetComponent<Text>();
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scored()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
