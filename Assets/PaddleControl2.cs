using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0f, 0.04f, 0f);
            if (transform.position.y >= 3.16)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, 3.16f, 0f);
            }


        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -0.04f, 0f);
            if (transform.position.y <= -3.38)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, -3.38f, 0f);
            }
        }
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager gm;
        gm = FindAnyObjectByType<GameManager>();
        if (collision.CompareTag("Ball") == true)
        {
            gm.ScoreR = gm.ScoreR + 1;
        }
    }*/
}
