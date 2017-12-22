using UnityEngine;

public class MenuToggle : MonoBehaviour {

    private bool isMenuVisible;

    private GameObject menuGame;
    private GameObject menuInventory;
    private GameObject menuStats;
    private GameObject menuSkills;
    private GameObject gamePaused;

    private void InitializeObjects()
    {
        menuInventory = GameObject.Find("menuInventory");
        menuStats = GameObject.Find("menuStats");
        menuSkills = GameObject.Find("menuEquip");
        menuGame = GameObject.Find("menuMain");


        gamePaused = GameObject.Find("Paused");

        SetMenuVisible(false);
        menuInventory.SetActive(false);
        menuStats.SetActive(false);
        menuSkills.SetActive(false);
    }

    // Use this for initialization
    void Start ()
    {
        InitializeObjects();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && gamePaused.activeInHierarchy == false) // Menu Appears
        {
            SetMenuVisible(true);
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && gamePaused.activeInHierarchy == true) // If in menu and tab is press, menu disappears
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
        gamePaused.SetActive(true);
        Time.timeScale = 0;
    }

    private void UnpauseGame()
    {
        gamePaused.SetActive(false);
        Time.timeScale = 1;
    }

}
