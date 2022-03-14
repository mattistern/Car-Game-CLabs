using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text pointsText;
    public void Setup(float score)
    {
        gameObject.SetActive(true);
        pointsText.text = "YOU SCORED " + score.ToString() + " POINTS";
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
