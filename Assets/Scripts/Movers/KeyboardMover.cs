using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMover : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;
    [SerializeField] bool enableVertical = false;
    private int mapWidth = 15;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        if (enableVertical)
        {
            float vertical = Input.GetAxis("Vertical"); // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise

            Vector3 movementVector = new Vector3(horizontal, vertical) * speed * Time.deltaTime;
            transform.position += movementVector;

        }
        else
        {
            //circular map hndler
            if (transform.position.x > -(mapWidth / 2) && transform.position.x <= (mapWidth / 2))
            {
                Vector3 movementVector = new Vector3(horizontal, 0) * speed * Time.deltaTime;
                transform.position += movementVector;
            }
            else
            {
                if (transform.position.x < -(mapWidth / 2))
                {
                    Vector3 circularMap = new Vector3(mapWidth - 1, 0);  //minus 1 to prevent bugs
                    transform.position += circularMap;
                }
                else
                {
                    Vector3 circularMap = new Vector3(mapWidth - 1, 0);  //minus 1 to prevent bugs
                    transform.position -= circularMap;
                }
            }
        }
    }
}
