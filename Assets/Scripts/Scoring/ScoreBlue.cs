using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBlue : MonoBehaviour
{
    public static ScoreBlue instance;
    public int maxScore;
    public Text blueScoreText;
    public float oldScore;
    static float blueScore = 0 - 3;
    
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        blueScoreText.text = blueScore.ToString() + " ";
    }

    public void AddPoint()
    {
        blueScore += 1;
        blueScoreText.text = blueScore.ToString() + " ";

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            blueScore = -3;

        }
    }


}
/*
{
    public int scoreBlue = 0;
    public Text scoreBlueText;
    public int maxScore;

    public GameObject Score;
    public GameObject Winner;

    private void Start()
    {
        scoreBlue = 0;
    }

    public void AddScore(int newScore)
    {
        //scoreBlue += newScore;

        scoreBlue = scoreBlue + 1;
    }

    public void UpdateScore()
    {
        scoreBlueText.text = "0" + scoreBlue;
    }
    void Update()
    {
        UpdateScore();

        if (scoreBlue == maxScore)
        {
            Score.SetActive(false);
            Winner.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D limb)
    {
        
        if (limb.tag == "limb")
        {
            scoreBlue = +1;
            Destroy(limb.gameObject);
        }
    }
}
*/
