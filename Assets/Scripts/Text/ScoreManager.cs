using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text lifeText;

    float score = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        lifeText.text = "SCORE: " + score.ToString();
    }

    public void AddPoints(float carValue)
    {
        score += carValue;
        lifeText.text = "SCORE: " + score.ToString();
    }

    public float GetScore()
    {
        return this.score;
    }
}
