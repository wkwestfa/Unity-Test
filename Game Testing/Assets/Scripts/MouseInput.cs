using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour {

    /* -----Functionality of Script-----
     * Attach this to an object you want
     * to move with the mouse, such as a
     * camera or a player
     -----------------------------------*/


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // For moving the mouse
        MouseAxisMovement();

        // For clicking buttons on mouse
        MouseButtonClicks();

    }

    void MouseAxisMovement()
    {
        float mouse_xVal = Input.GetAxis("Mouse X");
        float mouse_yVal = Input.GetAxis("Mouse Y");

        if (mouse_xVal != 0)
        {
            print("Mouse X movement selected: " + mouse_xVal);
        }

        if (mouse_yVal != 0)
        {
            print("Mouse Y movement selected: " + mouse_yVal);
        }
    }

    void MouseButtonClicks()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            print("Left mouse button is pressed");
        }

        if (Input.GetMouseButton(1)) // Right mouse button
        {
            print("Right mouse button is pressed");
        }

        if(Input.GetMouseButtonDown(2)) // Center mouse button
        {
            print("Center mouse button is pressed");
        }
    }

}
