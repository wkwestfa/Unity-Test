using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour {

    public GameObject textbox;

    private void OnTriggerStay(Collider other)
    {
        GameObject player = GameObject.FindWithTag("Player");

        if ((player.name == other.name) && Input.GetKey(KeyCode.E))
        {
            textbox.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        textbox.SetActive(false);
    }
}
