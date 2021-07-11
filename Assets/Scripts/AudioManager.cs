using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour {
    public Sound[] sounds;
    
    public GameObject rabbitAndGrass;
    private Boolean rabbitNotSpawned = true;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        // make it so you can't see the rabbit and grass till first song ends
        rabbitAndGrass.SetActive(false);

        foreach (Sound s in sounds) {
            // this makes the actual AudioSource component
            s.source = gameObject.AddComponent<AudioSource>();

            // fill the values of the AudioSource component attached to the AudioManager
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.name = s.name;
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

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        // when the first song ends, I want to spawn the rabbit. This is not the place to do this, but this is a game jam.
        Sound introSound = Array.Find(sounds, sound => sound.name == "Intro");

        if (rabbitNotSpawned) {
            if (!introSound.source.isPlaying) {
                print("Audio Source Ended");
                rabbitAndGrass.SetActive(true);
                rabbitNotSpawned = false;
            }
        }
    }
}