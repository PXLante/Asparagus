using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{

    public float mouseSensitivity = 50000f;
    public Transform playerBody;

    // Start is called before the first frame update
    void Start() 
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    /// Update is called every frame, if the MonoBehaviour is enabled.
    void Update()
    {
        // prebuilt component from Unity which gives us the X axis of the mouse.
        // delta time to keep movement consistent between framerates
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime * 2;

        playerBody.Rotate(Vector3.up * mouseX);
    }
}