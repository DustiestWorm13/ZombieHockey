using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreRed : MonoBehaviour
{
    public static ScoreRed instance;
    public int maxScore;
    public Text redScoreText;

    static float redScore = 0 - 3;
    
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        redScoreText.text = redScore.ToString() + " ";
    }

    public void AddPoint()
    {
        redScore += 1;
        redScoreText.text = redScore.ToString() + " ";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            redScore = -3;

        }
    }
}



/*
public class ScoreRed : MonoBehaviour
{
    
    public int scoreRed = 0;
    public Text scoreText;
    public int maxScore;

    public GameObject Score;
    public GameObject Winner;

    private void Start()
    {
        
        scoreRed = 0;
    }

    public void AddScore(int newScore)
    {
        
        scoreRed += newScore;
    }

    public void UpdateScore()
    {
        
        scoreText.text = "0" + scoreRed;
    }
    void Update()
    {
        UpdateScore();

        if (scoreRed == maxScore)
        {
            Score.SetActive(false);
            Winner.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider limb)
    {
        if (limb.tag == "mylimb")
        {
            scoreRed = +1;
            Destroy(limb.gameObject);
        }
    }
}
*/