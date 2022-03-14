using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 carSpeed;
    [SerializeField] GameObject player;
    [SerializeField] float increaseDifficulty;

    private bool pointsGained = false;
    private float difficulty;

    private void Start()
    {
        difficulty = ScoreManager.instance.GetScore();    //the difficulty incease with score
        carSpeed += new Vector3(0, -difficulty/(1/increaseDifficulty));
    }

    void Update()
    {
        transform.position += carSpeed * Time.deltaTime;

        if(player.transform.position.y > this.transform.position.y && !pointsGained)
        {
            ScoreManager.instance.AddPoints(carSpeed.y * -1);
            CarPastManager.instance.AnotherCarPast();
            pointsGained = true;
        }
        if (transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
