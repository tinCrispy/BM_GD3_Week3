using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour

{
    public GameObject GameOverScreen, StartScreen;
    //public int score = 0;
   // public TextMeshProUGUI verminVanquished;
   // public GameOverScreen gameOverScreen;

    // Start is called before the first frame update
    void Start()

    {
        Time.timeScale = 0;
        //UpdateScoreUI();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore(int points)
    {
       // score += points;
       // UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
      //  if (verminVanquished != null)
       // {
      //      verminVanquished.text = "Vermin Vanquished: " + score.ToString();
      //  }
    }

    public void GameOver()
    {
       GameOverScreen.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        StartScreen.SetActive(false);
    }
}
