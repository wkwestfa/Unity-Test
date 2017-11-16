using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour {

    /* Summary:
     * This script shoots a raycast out of the object
     * that it is attached to, and destroys any object
     * that the raycast hits
     * 
     * A raycast is essentially just an invisible line
     * that shoots out of an object
     */ 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");

        // Opposite because we rotate about those axes
        transform.Rotate(dirY, dirX, 0);

        CheckForRaycastHit();

	}

    void CheckForRaycastHit()
    {
        RaycastHit hit;

        if (Physics.Raycast (transform.position, transform.forward, out hit))
        {
            print(hit.collider.gameObject.name + " destroyed!");
            Destroy(hit.collider.gameObject);
        }
    }
}
