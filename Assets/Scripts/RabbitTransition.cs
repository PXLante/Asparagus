using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RabbitTransition : MonoBehaviour
{

    public Material angrySkybox;

    public GameObject InitialSongText;
    public GameObject secondSongText;

    private Boolean sadTransitionHasBegun = false;

    private Boolean secondSongStarted = false;

    // we're making this public so the tree script can access this.
    public Boolean secondSongEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // God forgive me for my sins
    void Update()
    {
        // this is horribly unoptimized, but again, this is a game jam.
        Sound secondSound = Array.Find(FindObjectOfType<AudioManager>().sounds, sound => sound.name == "Sad");

        if (secondSongStarted) {
            if (!secondSound.source.isPlaying) {
                secondSongEnded = true;
                print(secondSongEnded);
            }
        }
    }

    /// <summary>
    /// Called when the mouse enters the GUIElement or Collider.
    /// </summary>
    void OnMouseEnter()
    {
        print("entered");
    }

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown()
    {
        if (!sadTransitionHasBegun) {
            InitialSongText.SetActive(false);
            print("Enter");   
            FindObjectOfType<AudioManager>().Play("Sad");
            sadTransitionHasBegun = true;
            RenderSettings.skybox = angrySkybox;
            secondSongStarted = true;
            secondSongText.SetActive(true);
        }  
    }

}
