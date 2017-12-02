using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Item
{
    private int goldValue;
    private string itemName;

    #region G/S

    public int GetGoldValue()
    {
        return goldValue;
    }
    public void SetGoldValue(int value)
    {
        goldValue = value;
    }

    public string GetName()
    {
        return itemName;
    }

    public void SetName(string value)
    {
        itemName = value;
    }

    #endregion
}
