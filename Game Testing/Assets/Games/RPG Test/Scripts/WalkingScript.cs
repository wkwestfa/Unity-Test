using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoveObject();
	}

    void MoveObject()
    {
        float horizontalValue = Input.GetAxis("Horizontal") / 5;
        float verticalValue = Input.GetAxis("Vertical") / 5;

        if (horizontalValue != 0)
        {
            transform.Translate(horizontalValue, 0f, 0f);
        }

        if (verticalValue != 0)
        {
            transform.Translate(0f, 0f, verticalValue);
        }
    }
}
