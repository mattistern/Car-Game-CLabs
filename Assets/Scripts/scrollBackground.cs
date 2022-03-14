using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollBackground : MonoBehaviour
{
    public float speed = 0.2f;
    private Renderer re;
    void Start()
    {
        re = GetComponent<Renderer>();   
    }

    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * speed);
        re.material.mainTextureOffset = offset;
    }
}
