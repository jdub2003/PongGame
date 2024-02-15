using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-20f, 20f), Random.Range(-20f, 20f));

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SpriteRenderer ball = GetComponent<SpriteRenderer>();
        if (ball.color == Color.blue)
        {
            ball.color = Color.white;
        }
        else
        {
            ball.color = Color.blue;
        }

    }
}