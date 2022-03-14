using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CarPastManager : MonoBehaviour
{
    public static CarPastManager instance;

    public Text carPastText;

    float carPast = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        carPastText.text = "CAR PAST: " + carPast.ToString();
    }

    public void AnotherCarPast()
    {
        carPast += 1;
        carPastText.text = "CAR PAST: " + carPast.ToString();
    }
}
