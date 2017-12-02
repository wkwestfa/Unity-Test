using UnityEngine;
using UnityEngine.UI;

public class WeaponCreation : MonoBehaviour
{
    public string weaponName;
    public int damage;
    public int goldValue;
    public Element elementType;
    public WeaponType weaponType;

    private bool inTrigger;
    public GameObject textbox;
    public Text textboxText;

    Weapon newWeapon;

    private void Start()
    {

        newWeapon = new Sword(weaponName, damage, goldValue, elementType);


    }

    private void Update()
    {
        if(inTrigger == true && IsTextBoxVisible() && Input.GetKeyDown(KeyCode.E))
        {
            textbox.SetActive(false);
            Destroy(this.gameObject);
        }
        else if (inTrigger == true && IsTextBoxVisible() == false && Input.GetKeyDown(KeyCode.E))
        {
            PickUp(newWeapon);
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
        if (other.gameObject.tag == "Player")
        {
            inTrigger = false;
        }

        textbox.SetActive(false);
    }

    private void PrintStats(Weapon weapon)
    {
        int dmg = weapon.GetDamage();
        int gold = weapon.GetGoldValue();
        Element element = weapon.GetElementType();
        WeaponSpec weaponSpec = weapon.GetWeaponSpec();
        WeaponType weaponType = weapon.GetWeaponType();
        DamageType damageType = weapon.GetDamageType();


        print(dmg);
        print(gold);
        print(element);
        print(weaponSpec);
        print(weaponType);
        print(damageType);
    }

    public bool IsTextBoxVisible()
    {
        if (textbox.activeInHierarchy)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void PickUp(Item item)
    {
        textboxText.text = "Found " + item.GetName() + "!";
        textbox.SetActive(true);
    }
}
