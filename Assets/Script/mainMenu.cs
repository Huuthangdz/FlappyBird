using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainMenu : Singleton<mainMenu>
{

    [SerializeField] private Button Play;
    [SerializeField] private Button playover;
    [SerializeField] private GameObject PanelPlay;
    [SerializeField] private GameObject PanelGameOver;
    [SerializeField] private GameObject PanelScore;
    void Start()
    {
        Time.timeScale = 0f;
        Play.onClick.AddListener(() => PlayGame());   
        playover.onClick.AddListener(() => Restart());
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        PanelPlay.SetActive(false);
    }
    public void Restart()
    {
        PanelGameOver.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        PanelGameOver?.SetActive(true);
        PanelScore.SetActive(false);
    }
}
