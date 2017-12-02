using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand : Weapon {

    /// <summary>
    /// Create wand with name and baseline stats
    /// </summary>
    /// <param name="name"> Name of Wand </param>
    public Wand(string name)
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
    /// Create wand with name and damage set
    /// </summary>
    /// <param name="name"> Name of Wand </param>
    /// <param name="damage"> Damage it will deal </param>
    public Wand(string name, int damage) : this(name)
    {
        this.SetDamage(damage);
    }

    /// <summary>
    /// Create wand with name, damage, and goldValue
    /// </summary>
    /// <param name="name"> Name of Wand </param>
    /// <param name="damage"> Damage it will deal </param>
    /// <param name="goldValue"> Amount it is worth </param>
    public Wand(string name, int damage, int goldValue) : this(name)
    {
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
    }

    /// <summary>
    /// Create wand with name, damage, gold value, and element type
    /// </summary>
    /// <param name="name"> Name of Wand </param>
    /// <param name="damage"> Damage it will deal </param>
    /// <param name="goldValue"> Amount it is worth </param>
    /// <param name="elementType"> Element attached to it </param>
    public Wand(string name, int damage, int goldValue, Element elementType) : this(name)
    {
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
        this.SetElementType(elementType);
    }
}
