﻿using UnityEngine;
using UnityStandardAssets.Cameras;

public class menutoggle : MonoBehaviour {

    public Transform player;
    public GameObject menuGame;

    private bool isMenuVisible;
    private GameObject menuInventory;
    private GameObject menuStats;
    private GameObject menuSkills;

    private GameObject itemsPanel;

    private Color activeColor = new Color(255, 255, 255);
    private Color inactiveColor = new Color(150, 150, 150);

    // Use this for initialization
    void Start ()
    {
        menuInventory = GameObject.Find("menuInventory");
        menuStats = GameObject.Find("menuStats");
        menuSkills = GameObject.Find("menuEquip");
        itemsPanel = GameObject.Find("ItemsPanel");

        SetMenuVisible(false);
        menuInventory.SetActive(false);
        menuStats.SetActive(false);
        menuSkills.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return) && isMenuVisible == false)
        {
            SetMenuVisible(true);
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Return) && isMenuVisible == true)
        {
            SetMenuVisible(false);
            UnpauseGame();
        }
    }

    /// <summary>
    /// Sets whether the player is on the start menu or not
    /// </summary>
    /// <param name="isVisible"> Do you want the menu to be visible? </param>
    private void SetMenuVisible(bool isVisible)
    {
        isMenuVisible = isVisible;
        menuGame.SetActive(isVisible);
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }

    private void UnpauseGame()
    {
        Time.timeScale = 1;
    }

}
