using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
    public Button button;
    public Sprite on, off;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    private void Update()
    {
        if (AudioManager.isMusicMuted) button.image.sprite = off;
        else if (!AudioManager.isMusicMuted) button.image.sprite = on;
    }
}
