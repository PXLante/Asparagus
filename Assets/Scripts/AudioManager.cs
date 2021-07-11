using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour {
    public Sound[] sounds;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        foreach (Sound s in sounds) {
            // this makes the actual AudioSource component
            s.source = gameObject.AddComponent<AudioSource>();

            // fill the values of the AudioSource component attached to the AudioManager
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    void Start () 
    {
        Play("Intro");
    }

    void Play(string name) 
    {
        Sound selectedSound = Array.Find(sounds, sound => sound.name == name);
        selectedSound.source.Play();
    }
}