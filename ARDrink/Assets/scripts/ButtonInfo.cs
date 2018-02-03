using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour {

    [SerializeField]
    private string tableName;//maybe not needed
    public string TableName
    {
        get
        {
            return tableName;
        }
        set
        {
            tableName = value;
        }
    }

    [SerializeField]
    private int itemID;
    public int ItemID
    {
        get
        {
            return itemID;
        }
        set
        {
            itemID = value;
        }
    }

    [SerializeField]
    private int itemQuan;
    public int ItemQuan
    {
        get
        {
            return itemQuan;
        }
        set
        {
            itemQuan = value;
        }
    }
    [SerializeField]
    private int itemPrice;
    public int ItemPrice
    {
        get
        {
            return itemPrice;
        }
        set
        {
            itemPrice = value;
        }
    }
    [SerializeField]
    private float scale;
    public float Scale
    {
        get
        {
            return scale;
        }
        set
        {
            scale = value;
        }
    }
}
