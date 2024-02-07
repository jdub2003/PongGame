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
            transform.Translate(0f, 0.01f, 0f);
            if (transform.position.y >= 3.69)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, 3.69f, 0f);
            }


        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0f, -0.01f, 0f);

        }
        if (transform.position.y <= -3.69)
        {
            var x = transform.position.x;
            transform.position = new Vector3(x, -3.69f, 0f);
        }
    }
}
