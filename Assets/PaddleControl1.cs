using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PaddleControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0.04f, 0f);
            if (transform.position.y >= 2.66)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, 2.66f, 0f);
            }
          
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -0.04f, 0f);
            if (transform.position.y <= -2.66)
            {
                var x = transform.position.x;
                transform.position = new Vector3(x, -2.66f, 0f);
            }
        }
        //max y 3.69 min -3.69
        //Debug.Log(transform.position.y);
    }
}
