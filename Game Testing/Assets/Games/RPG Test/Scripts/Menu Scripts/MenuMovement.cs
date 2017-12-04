using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum MenuChoices { Items, Stats, Equip }

public class MenuMovement : MonoBehaviour
{
    private const int NUM_MAIN_MENU_PANELS = 3;

    private GameObject[] mainMenuPanels = new GameObject[NUM_MAIN_MENU_PANELS];

    private GameObject menuMain;
    private GameObject menuInventory;
    private GameObject menuStats;
    private GameObject menuEquip;

    private GameObject itemsPanelActive;
    private GameObject statsPanelActive;
    private GameObject equipPanelActive;

    private GameObject previousPanel; // The previous panel selected
    private GameObject selectedPanel; // The current panel selected

    private Color previousPanelColor;
    private Color selectedPanelColor;

    private int currentIndex = 0;

    // Use this for initialization
    void Start ()
    {
        menuMain = GameObject.Find("menuMain");
        menuInventory = GameObject.Find("menuInventory");
        menuStats = GameObject.Find("menuStats");
        menuEquip = GameObject.Find("menuEquip");

        itemsPanelActive = GameObject.Find("ItemsPanelActive");
        statsPanelActive = GameObject.Find("StatsPanelActive");
        equipPanelActive = GameObject.Find("EquipPanelActive");

        mainMenuPanels[0] = itemsPanelActive;
        mainMenuPanels[1] = statsPanelActive;
        mainMenuPanels[2] = equipPanelActive;

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

            previousPanel = mainMenuPanels[currentIndex + 1];
            selectedPanel = mainMenuPanels[currentIndex];

            previousPanel.SetActive(false); // Set the last panel to inactive
            selectedPanel.SetActive(true); // Set the current panel to active

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && currentIndex < (mainMenuPanels.Length - 1))
        {
            currentIndex++;

            previousPanel = mainMenuPanels[currentIndex - 1];
            selectedPanel = mainMenuPanels[currentIndex];

            previousPanel.SetActive(false); // Set the last panel to inactive
            selectedPanel.SetActive(true); // Set the current panel to active
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentIndex == 0)
            {
                ClickInventory();
            }
            else if (currentIndex == 1)
            {
                ClickStats();
            }
            else if (currentIndex == 2)
            {
                ClickEquip();
            }
        }
    }

    public void ChangeColor(RawImage menuPanel, Color newColor)
    {
        menuPanel.color = newColor;
    }

    public void ClickInventory()
    {
        menuMain.SetActive(false);
        menuInventory.SetActive(true);
        menuStats.SetActive(false);
        menuEquip.SetActive(false);
    }

    public void ClickStats()
    {
        menuMain.SetActive(false);
        menuInventory.SetActive(false);
        menuStats.SetActive(true);
        menuEquip.SetActive(false);
    }

    public void ClickEquip()
    {
        menuMain.SetActive(false);
        menuInventory.SetActive(false);
        menuStats.SetActive(false);
        menuEquip.SetActive(true);
    }
}
