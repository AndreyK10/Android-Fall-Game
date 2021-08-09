using UnityEngine;
using UnityEngine.UI;

public class AudioButton : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Sprite on, off;

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
