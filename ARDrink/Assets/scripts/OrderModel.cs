using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Azure.AppServices;
using System;

[Serializable]
public class OrderModel : DataModel {
    public string acc_id = "000001";
    public string order_id = "ABC001";
    public int table_id = 3;
    public int cup_size = 3;
    public int drink_id = 0;//matcha
    public int drink_quan = 2;//2 matchas
    public int top_id = 0;//tran chau
    public int top_quan = 5;//5 tran chau
}
