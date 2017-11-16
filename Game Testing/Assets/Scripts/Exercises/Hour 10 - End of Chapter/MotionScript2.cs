using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript2 : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
    {
        float verticalAxis = Input.GetAxis("Vertical") / 10;
        float horizontalAxis = Input.GetAxis("Horizontal") / 10;

        if(horizontalAxis != 0)
        {
            transform.Translate(horizontalAxis, 0f, 0f);
        }

        if (verticalAxis != 0)
        {
            transform.Translate(0f, verticalAxis, 0f);
        }

	}
}
