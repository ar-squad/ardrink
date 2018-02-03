using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour {
    //public GameObject button;
    public Text totalText;

    private float totalMoney = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CupSizeClicked(GameObject button)
    {
        if (button != null && GetComponent<BillInfo>()!=null && button.GetComponent<ButtonInfo>() != null)
        {
            GetComponent<BillInfo>().OrderModel.cup_size = button.GetComponent<ButtonInfo>().ItemID;
            TotalMoney(button.GetComponent<ButtonInfo>().ItemPrice);
        }
    }
    public void DrinkClicked(GameObject button)
    {
        if (button != null && GetComponent<BillInfo>() != null && button.GetComponent<ButtonInfo>() != null)
        {
            GetComponent<BillInfo>().OrderModel.drink_id = button.GetComponent<ButtonInfo>().ItemID;
            GetComponent<BillInfo>().OrderModel.drink_quan = button.GetComponent<ButtonInfo>().ItemQuan;
            TotalMoney(button.GetComponent<ButtonInfo>().ItemPrice);
        }
    }
    public void ToppingClicked(GameObject button)
    {
        if (button != null && GetComponent<BillInfo>() != null && button.GetComponent<ButtonInfo>() != null)
        {
            GetComponent<BillInfo>().OrderModel.top_id = button.GetComponent<ButtonInfo>().ItemID;
            GetComponent<BillInfo>().OrderModel.top_quan = button.GetComponent<ButtonInfo>().ItemQuan;
            TotalMoney(button.GetComponent<ButtonInfo>().ItemPrice);
        }
    }
    void TotalMoney(float m)
    {
        totalMoney += m;
        totalText.text = totalMoney+" VND";
    }
    void CupSizeScale(float m)
    {
        totalText.text = totalMoney*m + " VND";//need fixing
    }
}
