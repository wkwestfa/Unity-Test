using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHouseScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
    }

}
