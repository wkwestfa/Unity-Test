using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MenuChoices { Items, Stats, Equip }

public class MenuMovement : MonoBehaviour
{
    MenuChoices[] activeChoice = new MenuChoices[3];

    private GameObject menuMain;
    private GameObject menuInventory;
    private GameObject menuStats;
    private GameObject menuEquip;
    private GameObject menuPicker;
    private GameObject itemsPanel;

    private int currentIndex = 0;

    // Use this for initialization
    void Start ()
    {
        menuMain = GameObject.Find("menuMain");
        menuInventory = GameObject.Find("menuInventory");
        menuStats = GameObject.Find("menuStats");
        menuEquip = GameObject.Find("menuEquip");
        itemsPanel = GameObject.Find("ItemsPanel");
        menuPicker = GameObject.Find("MenuPicker");


        activeChoice[0] = MenuChoices.Items;
        activeChoice[1] = MenuChoices.Stats;
        activeChoice[2] = MenuChoices.Equip;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && currentIndex != 0)
        {
            currentIndex--;
            menuPicker.transform.Translate(0f, 32f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && currentIndex < (activeChoice.Length - 1))
        {
            currentIndex++;
            menuPicker.transform.Translate(0f, -32f, 0f);
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
            else if( currentIndex == 2)
            {
                ClickEquip();
            }
        }
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
