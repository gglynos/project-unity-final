using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    private bool isMuted;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // This makes sure the AudioManager persists between scenes
            LoadMuteState(); // Load the mute state from PlayerPrefs
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;
        AudioListener.volume = isMuted ? 0 : 1;
        SaveMuteState();
    }

    public bool IsMuted()
    {
        return isMuted;
    }

    private void SaveMuteState()
    {
        PlayerPrefs.SetInt("isMuted", isMuted ? 1 : 0);
    }

    private void LoadMuteState()
    {
        isMuted = PlayerPrefs.GetInt("isMuted", 0) == 1;
        AudioListener.volume = isMuted ? 0 : 1;
    }
}
