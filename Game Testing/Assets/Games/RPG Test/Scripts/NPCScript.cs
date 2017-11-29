using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCScript : MonoBehaviour {

    public GameObject textbox;
    public Text textboxText;
    public Text NPCText;

    private string[] textLines;
    private int currentIndex = 0;
    private bool inTrigger = false;

    private void Update()
    {
        if(inTrigger == true && Input.GetKeyDown(KeyCode.E))
        {
            if (NPCText.text != null)
            {
                textLines = NPCText.text.Split('\n');

                if (currentIndex < textLines.Length)
                {
                    print("current Index: " + currentIndex);
                    textbox.SetActive(true);
                    textboxText.text = textLines[currentIndex];
                    currentIndex++;
                }
                else
                {
                    textbox.SetActive(false);
                    currentIndex = 0;
                }

            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            inTrigger = false;
        }
        
        textbox.SetActive(false);
        currentIndex = 0;
    }
}
