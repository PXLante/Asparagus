using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TreeTransition : MonoBehaviour
{

    public Material happySkybox;
    public GameObject secondSongText;
    public GameObject finalSongText;
    public GameObject buddyRabbit;
    private Boolean finalSongHasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown()
    {
        if (!finalSongHasStarted) {
            if (FindObjectOfType<RabbitTransition>().secondSongEnded) {
                secondSongText.SetActive(false);
                finalSongText.SetActive(true);
                buddyRabbit.SetActive(true);
                FindObjectOfType<AudioManager>().Play("Ending");
                finalSongHasStarted = true;
                RenderSettings.skybox = happySkybox;
            }
        }  
    }
}
