using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finding_NonLocal_Objects : MonoBehaviour {

    //-------------------Function------------------------
    // Find & Manipulate an object that this script is 
    // not attached to
    //---------------------------------------------------



    //------------ Way to find object #1 -----------------

    // You can drag and drop an object onto this in Unity
    public GameObject objectToUse;

    // Update is called once per frame
    void Update ()
    {
        objectToUse.transform.Translate(5f, 0f, 5f); // Movement
        objectToUse.transform.Rotate(0f, 0f, 0f); // Rotation
        objectToUse.transform.localScale = new Vector3(0f, 0f, 0f); // Scale
	}
    //----------------------------------------------------




    //------------ Way to find object #2 -----------------

    // This will be used to actually target an object
    private GameObject target;

    //Tip: Use this in start, not update.  Too inefficient.
    private void FindObject()
    {

        // Object can be found by:
        // 1. Name
        target = GameObject.Find("Object Name");

        // 2. Tag - Most efficient because you can customize it
        target = GameObject.FindWithTag("ObjectTag");

        // 3. Type
        // No example, shouldn't be necessary ever

        target.transform.Translate(0f, 0f, 0f); // Movement
        target.transform.Rotate(0f, 0f, 0f); // Rotation
        target.transform.localScale = new Vector3(0f, 0f, 0f); // Scale

    }
    //-----------------------------------------------------

}
