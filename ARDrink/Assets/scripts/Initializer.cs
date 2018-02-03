using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour {
    public GameObject orderController;
	// Use this for initialization
	void Start () {
        orderController.GetComponent<BillInfo>().OrderModel = new OrderModel();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
