using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHouseScript : MonoBehaviour {

    Vector3 originalHouseSize;


    private void OnTriggerEnter(Collider other)
    {
        GameObject house = GameObject.FindGameObjectWithTag("House");
        originalHouseSize = new Vector3(house.transform.localScale.x, house.transform.localScale.y, house.transform.localScale.z);
        house.transform.localScale = new Vector3(0f, 0f, 0f);
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject house = GameObject.FindGameObjectWithTag("House");
        house.transform.localScale = originalHouseSize;
    }

}
