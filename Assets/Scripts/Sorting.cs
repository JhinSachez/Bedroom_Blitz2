using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sorting : MonoBehaviour
{
    public static int _sodaScore;
    public TMP_Text sodaScoreDisplay;

    public static int _bottleScore;
    public TMP_Text bottleScoreDisplay;
    
    public static int _jarScore;
    public TMP_Text jarScoreDisplay;
    
    public static int _cameraScore;
    public TMP_Text cameraScoreDisplay;
    
    public static int _weightScore;
    public TMP_Text weightScoreDisplay;

    void Start()
    {
        _sodaScore = 0;
        _bottleScore = 0;
        _cameraScore = 0;
        _jarScore = 0;
        _weightScore = 0;
    }

    void Update()
    {
        sodaScoreDisplay.text = _sodaScore.ToString()+(" / 5 ");
        bottleScoreDisplay.text = _bottleScore.ToString()+(" / 5 ");
        weightScoreDisplay.text = _weightScore.ToString()+(" / 5 ");
        cameraScoreDisplay.text = _cameraScore.ToString()+(" / 5 ");
        jarScoreDisplay.text = _jarScore.ToString()+(" / 5 ");
        
        if (_sodaScore < 0 || _bottleScore < 0 || _cameraScore < 0 || _jarScore < 0 || _weightScore < 0)
        {
            _sodaScore = 0;
            _bottleScore = 0;
            _cameraScore = 0;
            _jarScore = 0;
            _weightScore = 0;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Object"))
        {
            _sodaScore++;
        }

        if (collision.CompareTag("Camera"))
        {
            _cameraScore++;
        }

        if (collision.CompareTag("Jar"))
        {
            _jarScore++;
        }
        if (collision.CompareTag("Weight"))
        {
            _weightScore++;
        }
        if (collision.CompareTag("Bottle"))
        {
            _bottleScore++;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if(collision.CompareTag("Object"))
        {
            _sodaScore--;
        }
        
        if (collision.CompareTag("Camera"))
        {
            _cameraScore--;
        }

        if (collision.CompareTag("Jar"))
        {
            _jarScore--;
        }
        if (collision.CompareTag("Weight"))
        {
            _weightScore--;
        }
        if (collision.CompareTag("Bottle"))
        {
            _bottleScore--;
        }
    }
}
