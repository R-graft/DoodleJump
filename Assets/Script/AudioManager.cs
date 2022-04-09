using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager AudioInstance;

    [SerializeField]
    private Sound[] _gameSounds;

    private void Awake()
    {
        if (AudioInstance == null)
        {
            AudioInstance = this;
            DontDestroyOnLoad(gameObject);
        }

        foreach (Sound item in _gameSounds)
        {
            item.audioSource = gameObject.AddComponent<AudioSource>();

            item.audioSource.clip = item.clip;
            item.audioSource.loop = item.loop;
        }
    }
    public void PlaySound(string soundName)
    {
        Sound sound = Array.Find(_gameSounds, sound => sound.audioTag == soundName);

        sound.audioSource.Play();
    }
}
 
