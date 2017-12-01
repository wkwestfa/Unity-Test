using UnityEngine;

public class WeaponCreation : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Sword broadSword = new Sword(3, 10);

        broadSword.ShowStats();
	}

}
