using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Azure.AppServices;
using System;

[Serializable]
public class OrderModel : DataModel {
    public string acc_id = "";
    public string order_id = "";
    public int table_id=0;
    public float cup_size;
    public int drink_id;//matcha
    public int drink_quan;//2 matchas
    public int top_id;//tran chau
    public int top_quan;//5 tran chau
}
