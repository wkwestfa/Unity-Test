using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : Weapon {

    private string picture;
    private DamageType damageType;
    private WeaponSpec weaponSpec;
    private WeaponType weaponType;

    #region Getters and Setters

    public string GetPicture()
    {
        return picture;
    }
    public void SetPicture(string value)
    {
        picture = value;
    }

    public DamageType GetDamageType()
    {
        return damageType;
    }
    public void SetDamageType(DamageType value)
    {
        damageType = value;
    }

    private WeaponSpec GetWeaponSpec()
    {
        return weaponSpec;
    }
    private void SetWeaponSpec(WeaponSpec value)
    {
        weaponSpec = value;
    }

    public WeaponType GetWeaponType()
    {
        return weaponType;
    }
    public void SetWeaponType(WeaponType value)
    {
        weaponType = value;
    }

    #endregion

    public Dagger()
    {
        SetDamage(3);
        SetGoldValue(1);
        SetElementType(Element.None);
        SetPicture("Dagger");
        SetDamageType(DamageType.Pierce);
        SetWeaponSpec(WeaponSpec.One_Handed);
        SetWeaponType(WeaponType.Dagger);
    }

    public Dagger(int damage) : this()
    {
        this.SetDamage(damage);
    }

    public Dagger(int damage, int goldValue) : this()
    {
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
    }

    public Dagger(int damage, int goldValue, Element elementType) : this()
    {
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
        this.SetElementType(elementType);
    }
}
