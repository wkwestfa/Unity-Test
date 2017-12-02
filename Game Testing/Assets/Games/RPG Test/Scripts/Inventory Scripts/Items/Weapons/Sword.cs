public class Sword : Weapon
{

    /// <summary>
    /// Create sword with name and baseline stats
    /// </summary>
    /// <param name="name"> Name of sword </param>
    public Sword()
    {
        SetName("Sword");
        SetDamage(3);
        SetGoldValue(1);
        SetElementType(Element.None);
        SetPicture("Wand");
        SetDamageType(DamageType.Magic);
        SetWeaponSpec(WeaponSpec.One_Handed);
        SetWeaponType(WeaponType.Wand);
    }

    /// <summary>
    /// Create sword with name and damage set
    /// </summary>
    /// <param name="name"> Name of sword </param>
    /// <param name="damage"> Damage it will deal </param>
    public Sword(string name, int damage) : this()
    {
        this.SetName(name);
        this.SetDamage(damage);
    }

    /// <summary>
    /// Create sword with name, damage, and goldValue
    /// </summary>
    /// <param name="name"> Name of sword </param>
    /// <param name="damage"> Damage it will deal </param>
    /// <param name="goldValue"> Amount it is worth </param>
    public Sword(string name, int damage, int goldValue) : this()
    {
        this.SetName(name);
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
    }

    /// <summary>
    /// Create sword with name, damage, gold value, and element type
    /// </summary>
    /// <param name="name"> Name of sword </param>
    /// <param name="damage"> Damage it will deal </param>
    /// <param name="goldValue"> Amount it is worth </param>
    /// <param name="elementType"> Element attached to it </param>
    public Sword(string name, int damage, int goldValue, Element elementType)
    {
        this.SetName(name);
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
        this.SetElementType(elementType);
    }
}
