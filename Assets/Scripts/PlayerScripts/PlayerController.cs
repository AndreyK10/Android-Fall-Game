using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isDead;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("LoseZone")) GameOver(); 
        
        if (collision.CompareTag("Score"))
        {
            ScoreManager.instance.IncreaseScore();
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DangerousPlatform")) GameOver();
    }


    private void GameOver()
    {
        gameObject.SetActive(false);
        Time.timeScale = 0;
        isDead = true;
    }
}
