using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public float speed = 10f;

    private float minX = -2.55f;
    private float maxX = 2.55f;
       
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");
        Vector2 currentPosition = transform.position;

        if (h > 0 ) // moving right
        {
            currentPosition.x += speed * Time.deltaTime;
        }
        else if (h < 0) // moving left
        {
            currentPosition.x -= speed * Time.deltaTime;
        }

        if(currentPosition.x < minX)
        {
            currentPosition.x = minX;
        }

        if (currentPosition.x > maxX)
        {
            currentPosition.x = maxX;
        }

        transform.position = currentPosition;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb")
        {
            Time.timeScale = 0f;
        }
    }
}
