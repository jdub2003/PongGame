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
            if (transform.position.y >= 2.23)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, 2.23f, 0f);
            }


        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -0.04f, 0f);
            if (transform.position.y <= -2.8)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, -2.8f, 0f);
            }
        }
    }
}
