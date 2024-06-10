using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class regreso : MonoBehaviour
{
    [SerializeField] private int min, seg;
    public FadeScreen fadeScreen;

    //[SerializeField] private GameObject timeOverPanel;
    //[SerializeField] private GameObject victoryPanel;
    //[SerializeField] private GameObject checkMark;
    public float timeLeft;
    private bool ongoing;

    private void Awake()
    {
        timeLeft = (min * 60) + seg;
        ongoing = true;
    }

    void Update()
    {
        if (ongoing)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                ongoing = false;
                timeLeft = 0;
                //Time.timeScale = 0;
                SceneManager.LoadScene(0);
                //timeOverPanel.SetActive(true);
            }

            int tempMin = Mathf.FloorToInt(timeLeft / 60);
            int tempSeg = Mathf.FloorToInt(timeLeft % 60);

        }
    }
}
