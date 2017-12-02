public enum Element { Fire, Water, Lightning, None };
public enum DamageType { Pierce, Cleave, Slash, Blunt, Magic};
public enum WeaponSpec { One_Handed, Two_Handed, Ranged}
public enum WeaponType { Sword, Axe, Dagger, Wand}

public abstract class Weapon : Item
{
    private int damage;
    private Element elementType;
    private DamageType damageType;
    private WeaponSpec weaponSpec;
    private WeaponType weaponType;
    private string picture;

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

        public WeaponSpec GetWeaponSpec()
        {
            return weaponSpec;
        }

        public void SetWeaponSpec(WeaponSpec value)
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


}
