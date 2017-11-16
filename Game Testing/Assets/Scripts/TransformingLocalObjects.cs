using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformingLocalObjects : MonoBehaviour {

    //---Function---
    // Transform an object that the script is attached to
    //
    // Transforming includes:
    // 1. Position
    // 2. Rotation
    // 3. Scale
    //
    // Additional Notes:
    //

	// Update is called once per frame
	void Update ()
    {
        // Keep in mind that you have to attach this script
        transform.Translate(.05f, 0f, 0f); // Movement
        transform.Rotate(0f, 0f, 1f); // Rotation
        transform.localScale = new Vector3(5f, 1f, 5f); // Scale

    }
}
