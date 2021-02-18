using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Score stuff")]
    public int score;
    public Text textScore;
    public Text HighScore;
    [Header("Game over stuff")]
    public Text textScorePanel;
    public GameObject panel;
    public Text HighScorePanel;
    

    void Awake()
    {
        panel.gameObject.SetActive(false);
        HighScore.text = GetScore().ToString();
        //DontDestroyOnLoad(gameObject);
    }
    public void ScoreAdd(int pts)
    {
        //score+=Random.Range(1,4);
        score+=pts;
        textScore.text = score.ToString();

        if (score > GetScore())
        {
            PlayerPrefs.SetInt("Highscore", score);
            HighScore.text = score.ToString();
        }
    }

    public int GetScore()
    {
        int i = PlayerPrefs.GetInt("Highscore");
        return i;
    }

    public void HitBomb()
    {
        Time.timeScale = 0f;

        //SceneManager.LoadScene("GameOver");
        //print("XD");
        panel.gameObject.SetActive(true);
        textScorePanel.text = score.ToString();
        HighScorePanel.text = GetScore().ToString();
        
        
        
    }
}
