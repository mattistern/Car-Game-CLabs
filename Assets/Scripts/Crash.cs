using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Crash : MonoBehaviour
{
    public AudioSource carCrash;

    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    
    private int livesLeft = 2;
    public GameOver gameOverScreen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && livesLeft == 0)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            playAudio();

            LifeManager.instance.ReduceLife();
            GameOver();
        }
        else
        {
            livesLeft -= 1;
            Destroy(other.gameObject);

            LifeManager.instance.ReduceLife();
        }
    }

    public void playAudio()
    {
        carCrash.Play();
    }

    public void GameOver()
    {
        gameOverScreen.Setup(ScoreManager.instance.GetScore());
    }
}
