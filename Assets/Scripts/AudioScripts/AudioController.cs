using UnityEngine;

public class AudioController : MonoBehaviour
{
    public void MuteMusic()
    {
        AudioManager.instance.MuteMusic(AudioManager.BGMUSIC);
    }
}