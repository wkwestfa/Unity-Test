using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item
{
    private int goldValue;

    #region G/S

    public int GetGoldValue()
    {
        return goldValue;
    }
    public void SetGoldValue(int value)
    {
        goldValue = value;
    }

    #endregion

    bool PickUp()
    {
        // If player is within trigger area, and press 'e' then return true
        // else return false
        return false;
    }

}
