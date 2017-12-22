using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour {

    public GameObject textBox;
    private GameObject gamePaused;
	// Use this for initialization
	void Start ()
    {
        gamePaused = GameObject.Find("Paused");

        gamePaused.SetActive(false);
        textBox.SetActive(false);
	}
}
