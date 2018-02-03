using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillInfo : MonoBehaviour {
    private OrderModel orderModel;
    public OrderModel OrderModel
    {
        get
        {
            return orderModel;
        }
        set
        {
            orderModel = value;
        }
    }
}
