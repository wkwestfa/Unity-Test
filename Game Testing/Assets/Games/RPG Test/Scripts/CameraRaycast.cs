using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {

        CheckForRaycastHit();

    }

    void CheckForRaycastHit()
    {
        RaycastHit hit;
        GameObject house;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            print(hit.collider.gameObject.name + " destroyed!");

            if (hit.collider.gameObject.tag == "House")
            {
                print("House hit");
                house = hit.collider.gameObject;

                do
                {
                    print("House do");
                    house.SetActive(false);
                }
                while (hit.collider.gameObject.tag == "House");

                house.SetActive(true);
            }




        }
    }
}
