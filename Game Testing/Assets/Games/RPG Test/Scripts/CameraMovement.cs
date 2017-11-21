using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	
	// Update is called once per frame
	void Update ()
    {
        MouseAxisMovement();
	}

    void MouseAxisMovement()
    {
        float mouse_xVal = Input.GetAxis("Mouse X");
        float mouse_yVal = Input.GetAxis("Mouse Y");

        if (mouse_xVal != 0)
        {
            transform.Rotate(mouse_xVal, 0f, 0f);
        }

        if (mouse_yVal != 0)
        {
            transform.Rotate(0f, mouse_yVal, 0f);
        }
    }


}
