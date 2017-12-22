using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBack : MonoBehaviour {

    private GameObject menuMain;
    private GameObject menuInventory;
    private GameObject menuStats;
    private GameObject menuEquip;

    // Use this for initialization
    void Start ()
    {

        menuMain = GameObject.Find("menuMain");
        menuInventory = GameObject.Find("menuInventory");
        menuStats = GameObject.Find("menuStats");
        menuEquip = GameObject.Find("menuEquip");

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Backspace) && Time.timeScale == 0)
        {
            ClickBack();
        }
    }

    public void ClickBack()
    {
        menuMain.SetActive(true);
        menuInventory.SetActive(false);
        menuStats.SetActive(false);
        menuEquip.SetActive(false);
    }
}
