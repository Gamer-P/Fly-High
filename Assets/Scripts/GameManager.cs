using UnityEngine;
using UnityEngine.Rendering;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float scoreCounter;
    //private float highScore;
    public TextMeshProUGUI score;
    //public TextMeshProUGUI highScoreText;
    public GameObject play;

    public PlayerMovement playerMovement;

    public GameObject gameOver;
    public GameObject getReady;

    private bool isGameStarted = false;

    public AudioSource sound;

    private void Awake()
    {
        Pause();
        //LoadHighScore();
        //UpdateHighScoreUI();
    }

    private void Update()
    {
        if (isGameStarted)
        {
            IncreaseScore();
        }
        IncreaseScore();        
    }
    public void TriggerPlay()
    {
        if (gameOver.activeSelf)
        {
            RestartGame();
            return;
        }

        play.SetActive(false);
        getReady.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1.0f;
        playerMovement.enabled = true;
        isGameStarted = true;
    }

    public void IncreaseScore()
    {

        scoreCounter += Time.deltaTime;
        score.text = scoreCounter.ToString("0");
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;
        playerMovement.enabled = false;
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        play.SetActive(true);
        Time.timeScale = 0.0f;

        //SaveHighScore();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SoundEffect()
    {
        sound.Play();
    }

    //void SaveHighScore()
    //{
    //    if (scoreCounter > highScore)
    //    {
    //        highScore = scoreCounter;
    //        highScore = PlayerPrefs.GetFloat("HighScore", highScore);
    //        PlayerPrefs.Save();
    //    }
    //}

    //void LoadHighScore()
    //{
    //    highScore = PlayerPrefs.GetFloat("HighScore", 0);
    //}
    //private void UpdateHighScoreUI()
    //{
    //    if(highScoreText != null)
    //    {
    //        highScoreText.text = "High Score:" + highScore.ToString("0");
    //    }
    //}
}
