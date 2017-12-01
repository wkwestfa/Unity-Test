public class Sword : Weapon
{
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

    public Sword()
    {
        SetDamage(3);
        SetGoldValue(1);
        SetElementType(Element.None);
        SetPicture("Sword");
        SetDamageType(DamageType.Slash);
        SetWeaponSpec(WeaponSpec.One_Handed);
        SetWeaponType(WeaponType.Sword);
    }

    public Sword(int damage) : this()
    {
        this.SetDamage(damage);
    }

    public Sword(int damage, int goldValue) : this()
    {
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
    }

    public Sword(int damage, int goldValue, Element elementType)
    {
        this.SetDamage(damage);
        this.SetGoldValue(goldValue);
        this.SetElementType(elementType);
    }

    public void ShowStats()
    {
        int damage;
        int goldValue;
        string picture;
        Element elementType;
        WeaponSpec weaponSpec;
        DamageType damageType;
        

        damage = GetDamage();
        goldValue = GetGoldValue();
        picture = GetPicture();
        elementType = GetElementType();
        weaponSpec = GetWeaponSpec();
        damageType = GetDamageType();
    }
}
