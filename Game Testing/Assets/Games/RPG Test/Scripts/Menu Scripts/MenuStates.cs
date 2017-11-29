using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStates : MonoBehaviour {

    enum menuStates {Inventory, Stats, Skills };

    public GameObject menuMain;
    public GameObject menuInventory;
    public GameObject menuStats;
    public GameObject menuSkills;

    public void ClickInventory()
    {
        menuMain.SetActive(false);
        menuInventory.SetActive(true);
        menuStats.SetActive(false);
        menuSkills.SetActive(false);
    }

    public void ClickStats()
    {
        menuMain.SetActive(false);
        menuInventory.SetActive(false);
        menuStats.SetActive(true);
        menuSkills.SetActive(false);
    }

    public void ClickSkills()
    {
        menuMain.SetActive(false);
        menuInventory.SetActive(false);
        menuStats.SetActive(false);
        menuSkills.SetActive(true);
    }

    public void ClickBack()
    {
        menuMain.SetActive(true);
        menuInventory.SetActive(false);
        menuStats.SetActive(false);
        menuSkills.SetActive(false);
    }

}
