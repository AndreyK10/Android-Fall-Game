using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public static int Score { get; private set; }
    public const string PREFS_HIGHSCORE = "HS_v1.0";

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        Score = 0;    
    }

    private void Update()
    {
        if (PlayerController.isDead)
        {
            if (Score > PlayerPrefs.GetInt(PREFS_HIGHSCORE)) PlayerPrefs.SetInt(PREFS_HIGHSCORE, Score);
        }
    }

    public void IncreaseScore()
    {
        Score++;
    }
}
