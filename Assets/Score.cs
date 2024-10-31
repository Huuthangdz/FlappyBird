using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text;

public class Score : Singleton<Score>
{
    
    [SerializeField] private TextMeshProUGUI _HightScore;
    [SerializeField] private TextMeshProUGUI _CurrentScore;

    private int score;

 
    private void Start()
    {
        _CurrentScore.text = score.ToString();
        _HightScore.text = PlayerPrefs.GetInt("hightScore", 0).ToString();
        UpdateHightScore();
    }

    private void UpdateHightScore()
    {
        if (score > PlayerPrefs.GetInt("hightScore"))
        {
            PlayerPrefs.SetInt("hightScore",score);
            _HightScore.text = score.ToString();
        }
    }
    public void UpdateScore()
    {
        score++;
        _CurrentScore.text = score.ToString() ;
        UpdateHightScore();
    }
}
