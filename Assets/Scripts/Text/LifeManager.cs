using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{
    public static LifeManager instance;

    public Text lifeText;

    int lives = 3;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        lifeText.text = "LIVES: " + lives.ToString();
    }

    public void ReduceLife()
    {
        lives -= 1;
        lifeText.text = "LIVES: " + lives.ToString();
    }
}
