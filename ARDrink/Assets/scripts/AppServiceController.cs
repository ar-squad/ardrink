using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Azure.AppServices;
using RESTClient;
using System.Net;

public class AppServiceController : MonoBehaviour {
    [Header("Azure App Service")]
    // Azure Mobile App connection strings
    [SerializeField]
    private string _appUrl = "PASTE_YOUR_APP_URL";
    private AppServiceClient _client;
    private AppServiceTable<OrderModel> _model;
    private OrderModel orderModel;
    public GameObject orderController;
    // Use this for initialization
    void Start () {
        _client = new AppServiceClient(_appUrl);
        _model = _client.GetTable<OrderModel>("bill_info");
        orderModel = orderController.GetComponent<BillInfo>().OrderModel;
    }
	
	// Update is called once per frame
	void Update () {

        orderModel = orderController.GetComponent<BillInfo>().OrderModel;
    }

    public void Insert()
    {
        orderModel.acc_id = "000001";
        orderModel.order_id = "ABC001";
        orderModel.table_id = 3;
        //orderModel.cup_size = 3;
        //orderModel.drink_id = 0;//matcha
        //orderModel.drink_quan = 2;//2 matchas
        //orderModel.top_id = 0;//tran chau
        //orderModel.top_quan = 5;//5 tran chau
        StartCoroutine(_model.Insert<OrderModel>(orderModel, OnInsertCompleted));
        
    }

    private void OnInsertCompleted(IRestResponse<OrderModel> response)
    {
        if (!response.IsError && response.StatusCode == HttpStatusCode.Created)
        {
            Debug.Log("OnInsertItemCompleted: " + response.Content + " status code:" + response.StatusCode + " data:" + response.Data);
            OrderModel item = response.Data; // if successful the item will have an 'id' property value
            orderModel = item;
        }
        else
        {
            Debug.LogWarning("Insert Error Status:" + response.StatusCode + " Url: " + response.Url);
        }
    }
}
