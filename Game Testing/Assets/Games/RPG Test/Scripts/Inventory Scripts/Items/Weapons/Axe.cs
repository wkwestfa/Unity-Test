using UnityEngine;

public class Axe : Weapon {


    /// <summary>
    /// Create axe with name and baseline stats
    /// </summary>
    /// <param name="name"> Name of axe </param>
    public Axe(string name)
    {
        SetName(name);
        SetDamage(3);
        SetGoldValue(1);
        SetElementType(Element.None);
        SetPicture("Wand");
        SetDamageType(DamageType.Magic);
        SetWeaponSpec(WeaponSpec.One_Handed);
        SetWeaponType(WeaponType.Wand);
    }

    /// <summary>
    /// Create axe with name and damage set
    /// </summary>
    /// <param name="name"> Name of axe </param>
    /// <param name="damage"> Damage it will deal </param>
    public Axe(string name, int damage) : this(name)
    {
        this.SetDamage(damage);
    }

    /// <summary>
    /// Create axe with name, damage, and goldValue
    /// </summary>
    /// <param name="name"> Name of axe </param>
    /// <param name="damage"> Damage it will deal </param>
    /// <param name="goldValue"> Amount it is worth </param>
    public Axe(string name, int damage, int goldValue) : this(name)
    {
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
    }

    /// <summary>
    /// Create axe with name, damage, gold value, and element type
    /// </summary>
    /// <param name="name"> Name of axe </param>
    /// <param name="damage"> Damage it will deal </param>
    /// <param name="goldValue"> Amount it is worth </param>
    /// <param name="elementType"> Element attached to it </param>
    public Axe(string name, int damage, int goldValue, Element elementType) : this(name)
    {
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
        this.SetElementType(elementType);
    }
}
