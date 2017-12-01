public enum Element { Fire, Water, Lightning, None };
public enum DamageType { Pierce, Cleave, Slash, Blunt, Magic};
public enum WeaponSpec { One_Handed, Two_Handed, Ranged}
public enum WeaponType { Sword, Axe, Dagger, Wand}

public abstract class Weapon : Item
{
    private int damage;
    private Element elementType;

    #region Getters and Setters

    public int GetDamage()
    {
        return damage;
    }
    public void SetDamage(int value)
    {
        damage = value;
    }

    public Element GetElementType()
    {
        return elementType;
    }
    public void SetElementType(Element value)
    {
        elementType = value;
    }

    #endregion


}
