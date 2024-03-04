using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text ScoreLUI;
    [SerializeField] TMP_Text ScoreRUI;
    public int ScoreL=0;
    public int ScoreR=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreLUI.text = ScoreL.ToString();
        ScoreRUI.text = ScoreR.ToString();
    }
}
