using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour {

    private void Start()
    {
    }

    // Update is called once per frame
    void Update ()
    {
        
	}

    private void OnTriggerEnter(Collider other)
    {

        
    }

    private void OnTriggerStay(Collider other)
    {
        GameObject player = GameObject.FindWithTag("Player");

        if ((player.name == other.name) && Input.GetKey(KeyCode.E))
        {
            print("Hello");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
