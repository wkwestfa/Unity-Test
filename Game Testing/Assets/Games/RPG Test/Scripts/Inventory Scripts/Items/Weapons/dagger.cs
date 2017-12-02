using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : Weapon {

    /// <summary>
    /// Create dagger with name and baseline stats
    /// </summary>
    /// <param name="name"> Name of dagger </param>
    public Dagger(string name)
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
    /// Create dagger with name and damage set
    /// </summary>
    /// <param name="name"> Name of dagger </param>
    /// <param name="damage"> Damage it will deal </param>
    public Dagger(string name, int damage) : this(name)
    {
        this.SetDamage(damage);
    }

    /// <summary>
    /// Create dagger with name, damage, and goldValue
    /// </summary>
    /// <param name="name"> Name of dagger </param>
    /// <param name="damage"> Damage it will deal </param>
    /// <param name="goldValue"> Amount it is worth </param>
    public Dagger(string name, int damage, int goldValue) : this(name)
    {
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
    }

    /// <summary>
    /// Create dagger with name, damage, gold value, and element type
    /// </summary>
    /// <param name="name"> Name of dagger </param>
    /// <param name="damage"> Damage it will deal </param>
    /// <param name="goldValue"> Amount it is worth </param>
    /// <param name="elementType"> Element attached to it </param>
    public Dagger(string name, int damage, int goldValue, Element elementType) : this(name)
    {
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
        this.SetElementType(elementType);
    }
}
