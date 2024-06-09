using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jars : MonoBehaviour
{
    public static int _score;
    public TMP_Text scoreDisplay;

    void Start()
    {
        _score = 0;
    }

    void Update()
    {
        scoreDisplay.text = _score.ToString()+(" / 5 ");
        if (_score < 0)
        {
            _score = 0;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Jar"))
        {
            _score++;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if(collision.CompareTag("Jar"))
        {
            _score--;
        }
    }
}
