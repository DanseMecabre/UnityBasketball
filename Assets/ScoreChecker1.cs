using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreChecker1: MonoBehaviour
{
    private int score;
    public TMP_Text label;
    void Start()
    {
        score = 0;
    }
    void OnTriggerExit(Collider Basketball)
    {
        if(Basketball.tag=="Basketball")
        {
            score++;
            label.text = "Успешных бросков игроком 2: "+score;
            Debug.Log("Score: "+score);
        }
    }
    public void Reset()
    {
        score=0;
        label.text = "Успешных бросков игроком 2: "+score;
    }
}
