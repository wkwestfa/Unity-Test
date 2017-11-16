using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour {

    public GameObject objectToMove;

    /*----------Function---------------
     * This script will control a  game object depending on the input
     * from the player.
    ------------------------------------*/

    // Update is called once per frame
    void Update ()
    {
        MoveObject();

        RotateObject();

	}

    void MoveObject()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        if (horizontalValue != 0)
        {
            objectToMove.transform.Translate(horizontalValue, 0f, 0f);
        }

        if(verticalValue != 0)
        {
            objectToMove.transform.Translate(0f, verticalValue, 0f);
        }
    }

    void RotateObject()
    {
        float mouse_xVal = Input.GetAxis("Mouse X");
        float mouse_yVal = Input.GetAxis("Mouse Y");

        if(mouse_xVal != 0)
        {
            objectToMove.transform.Rotate(mouse_xVal, 0f, 0f);
        }

        if(mouse_yVal != 0)
        {
            objectToMove.transform.Rotate(0f, mouse_yVal, 0f);
        }

    }

}
