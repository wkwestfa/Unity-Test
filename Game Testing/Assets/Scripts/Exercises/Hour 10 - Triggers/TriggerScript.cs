using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    /* Summary:
     * This script allows us to trigger an event
     * upon one object colliding into another.
     */

    // When something enters the object this script is attached to
    // other = The object that is entering
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered the cube");
    }

    // When something stays inside the object this script is attached to
    // other = The object that is entering
    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " has stayed in the cube");
    }

    // When something leaves the object this script is attached to
    // other = The object that is entering
    private void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has exited the cube");
    }


}