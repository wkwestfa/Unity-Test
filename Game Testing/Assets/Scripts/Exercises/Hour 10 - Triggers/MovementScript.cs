using UnityEngine;

public class MovementScript : MonoBehaviour {

    /* Summary:
     * Move an object using the mouse
     */

	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X") / 10;
        float mouseY = Input.GetAxis("Mouse Y") / 10;

        transform.Translate(mouseX, mouseY, 0f);
	}
}
