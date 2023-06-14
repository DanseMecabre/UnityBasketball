using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checker2: MonoBehaviour
{
    private int score;
    public double a;
    public TMP_Text label;
    void Start()
    {
        a = 0;
    }
    void OnTriggerExit(Collider Basketball)
    {
        if(Basketball.tag=="Basketball")
        {
            a += 0.5;
            label.text = "Количество взятых мячей игроком 2:"+a;
            Debug.Log("Score: "+a);
        }
    }
    public void Reset()
    {
        a = 0;
        label.text = "Количество взятых мячей игроком 2:"+a;
    }
}
