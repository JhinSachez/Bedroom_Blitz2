using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private int min, seg;
    [SerializeField] private TextMeshPro timer;
    //[SerializeField] private GameObject timeOverPanel;
    //[SerializeField] private GameObject victoryPanel;
    //[SerializeField] private GameObject checkMark;
    private float timeLeft;
    private bool ongoing;
    
    private void Awake()
    {
        timeLeft = (min * 60) + seg;
        ongoing = true;
    }
    
    void Update()
    {
        if(ongoing)
        {
            timeLeft -= Time.deltaTime;
            if(timeLeft < 0)
            {
                ongoing = false;
                timeLeft = 0;
                Time.timeScale = 0f;
                //timeOverPanel.SetActive(true);
            }
            int tempMin = Mathf.FloorToInt(timeLeft / 60);
            int tempSeg = Mathf.FloorToInt(timeLeft % 60);
            timer.text = string.Format("{00:00}:{01:00}", tempMin, tempSeg);
    
            /*if(ClearCon._score == 5) //cambiar numero dependiendo de objetos en el mundo
            {
                ClearCondition();
                victoryPanel.SetActive(true);
            }*/
        }
    }
    
    /*private void ClearCondition()
    {
        ongoing = false;
        Time.timeScale = 0f;
    }*/
}
