using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum MenuChoices {Items, Stats, Equip}

public class MenuMovement : MonoBehaviour
{
    private const int NUM_MAIN_MENU_PANELS = 3;

    private GameObject[] arrMainMenuPanels = new GameObject[NUM_MAIN_MENU_PANELS];
    private GameObject[] arrMenus = new GameObject[NUM_MAIN_MENU_PANELS];

    private GameObject menuMain;
    private GameObject menuInventory;
    private GameObject menuStats;
    private GameObject menuEquip;

    private GameObject itemsPanelActive;
    private GameObject statsPanelActive;
    private GameObject equipPanelActive;

    private GameObject previousPanel; // The previous panel selected
    private GameObject selectedPanel; // The current panel selected

    private int currentIndex = 0;

    // Use this for initialization
    void Start ()
    {
        itemsPanelActive = GameObject.Find("ItemsPanelActive");
        statsPanelActive = GameObject.Find("StatsPanelActive");
        equipPanelActive = GameObject.Find("EquipPanelActive");

        menuMain = GameObject.Find("menuMain");
        menuInventory = GameObject.Find("menuInventory");
        menuStats = GameObject.Find("menuStats");
        menuEquip = GameObject.Find("menuEquip");

        arrMainMenuPanels = new GameObject[] { itemsPanelActive, statsPanelActive, equipPanelActive };  // Set all panels here
        arrMenus = new GameObject[] {menuInventory, menuStats, menuEquip };                             // Set all Menus here

        statsPanelActive.SetActive(false); // Set Stats Panel to inactive when the player opens the menu
        equipPanelActive.SetActive(false); // Set Equip panel to inactive when the player opens the menu
    }
	
	// Update is called once per frame
	void Update ()
    {

        // This will check which panel the user is currently on, and change which one is active
        CheckActivePanel();
    }

    public void CheckActivePanel()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentIndex > 0)
        {
            currentIndex--;

            previousPanel = arrMainMenuPanels[currentIndex + 1];
            selectedPanel = arrMainMenuPanels[currentIndex];

            previousPanel.SetActive(false); // Set the last panel to inactive
            selectedPanel.SetActive(true); // Set the current panel to active

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && currentIndex < (arrMainMenuPanels.Length - 1))
        {
            currentIndex++;

            previousPanel = arrMainMenuPanels[currentIndex - 1];
            selectedPanel = arrMainMenuPanels[currentIndex];

            previousPanel.SetActive(false); // Set the last panel to inactive
            selectedPanel.SetActive(true); // Set the current panel to active

        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            clickPanel(arrMenus[currentIndex]);
        }
    }

    public void clickPanel(GameObject currentMenu)
    {
        menuMain.SetActive(false);
        currentMenu.SetActive(true);
    }
}
