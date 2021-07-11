using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RabbitTransition : MonoBehaviour
{

    public Material angrySkybox;
    private Boolean sadTransitionHasBegun = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            print("Enter");   
            FindObjectOfType<AudioManager>().Play("Sad");
            sadTransitionHasBegun = true;
            RenderSettings.skybox = angrySkybox;
        }  
    }

}
