using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour {

    /* -----Functionality of Script-----
    * Attach this to an object you want
    * to use keyboard input, such as
    * a camera or player
    -----------------------------------*/

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // For movement with WASD
        MovementWithWASD();

        // For any key on the keyboard
        SpecificKeyInput();
	}

    void MovementWithWASD()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        if (horizontalValue != 0)
        {
            print("Horizontal movement selected: " + horizontalValue);
        }

        if(verticalValue != 0)
        {
            print("Vertical movement selected: " + verticalValue);
        }
    }

    void SpecificKeyInput()
    {
        //------------ This piece is for generic keys-----------
        if (Input.anyKeyDown)
        {
            print("Key being pressed is: " + Input.inputString);
        }
        // ------------------------------------------------------

        //------------ This piece is for specific keys-----------
        if (Input.GetKey(KeyCode.K)) // There is a keycode for every key
        {
            print("Key being pressed is: " + Input.inputString);
        }
        // ------------------------------------------------------

        

    }


}
