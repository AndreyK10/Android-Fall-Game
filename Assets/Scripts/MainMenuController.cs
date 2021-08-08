using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highscoreText;
    [SerializeField] private Button deleteButton;

    private void Start()
    {
        DisplayHighscore();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void DeleteHighscore()
    {
        PlayerPrefs.DeleteAll();
        DisplayHighscore();
    }

    private void DisplayHighscore()
    {
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt(ScoreManager.PREFS_HIGHSCORE).ToString();
    }
}
