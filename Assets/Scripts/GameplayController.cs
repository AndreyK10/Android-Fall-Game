using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameplayController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText, highscoreText, gOScoreText;
    [SerializeField] private GameObject pausePanel, gameOverPanel;
    [SerializeField] private Button pauseButton;

    public static bool isPaused;

    private void Awake()
    {
        Time.timeScale = 1;
        PlayerController.isDead = false;
        isPaused = false;
    }
    private void Update()
    {
        scoreText.text = ScoreManager.Score.ToString();
        if (PlayerController.isDead)
        {
            Time.timeScale = 0;
            gameOverPanel.gameObject.SetActive(true);
            scoreText.gameObject.SetActive(false);
            pauseButton.gameObject.SetActive(false);
            highscoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt(ScoreManager.PREFS_HIGHSCORE).ToString();
            gOScoreText.text = ScoreManager.Score.ToString();
        }
    }

    public void PauseGame()
    {
        SwitchPause(0, true, false, true);
    }

    public void ResumeGame()
    {
        SwitchPause(1, false, true, false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    private void SwitchPause(int timescale, bool ispaused, bool pausebutton, bool pausepanel)
    {
        Time.timeScale = timescale;
        isPaused = ispaused;
        pauseButton.gameObject.SetActive(pausebutton);
        pausePanel.gameObject.SetActive(pausepanel);
    }
}
