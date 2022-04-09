using UnityEngine;

[System.Serializable]
public class Sound
{
    [HideInInspector]
    public AudioSource audioSource;

    public AudioClip clip;
    
    public bool loop;

    public string audioTag;
}
