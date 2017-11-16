using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        print("Sphere hit " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        print("Sphere hit " + other.name);
    }

    private void OnTriggerStay(Collider other)
    {
        print("Sphere hit " + other.name);
    }

}
