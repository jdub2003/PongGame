using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] GameObject Ball1;
    [SerializeField] GameObject Ball2;
    [SerializeField] GameObject Ball3;
    [SerializeField] GameObject Ball4;
    GameManager gm;
    //gm = FindAnyObjectByType<GameManager>();
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
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
        SpriteRenderer ball = GetComponent<SpriteRenderer>();
        if (ball.color == Color.blue)
        {
            ball.color = Color.white;
        }
        else
        {
            ball.color = Color.blue;
        }
        gm = FindAnyObjectByType<GameManager>();
        /*if (gm.ScoreL >= 50 || gm.ScoreR >= 50)
        {
            Destroy(GetComponent<GameObject>());
        }*/

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //GameManager gm;
        gm = FindAnyObjectByType<GameManager>();
        

        if (collision.CompareTag("PaddleLeft")==true)
        {
            if(gm.ScoreL >=50)
            {
                //Destroy(GetComponent<GameObject>());//Destory balls
                GameOver();
                
            }
            else
            {
                gm.ScoreL = gm.ScoreL + 1;
            }
            
        }

        if (collision.CompareTag("PaddleRight") == true)
        {
            if (gm.ScoreR >=50)
            {
                //Destroy(GetComponent<GameObject>());//Destroy balls
                GameOver();
                
            }
            else
            {
                gm.ScoreR = gm.ScoreR + 1;
            }
            
        }
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        Ball1.SetActive(false);
        Ball2.SetActive(false);
        Ball3.SetActive(false);
        Ball4.SetActive(false);
    }
}