using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour {

    public void ShowNHide(GameObject model)
    {
        if (!model.activeSelf)
        {
            foreach (Transform child in model.transform.parent)
            {

                model.SetActive(true);
                model.GetComponent<Animator>().Play("slidein");
                if (child.name != model.name) {
                    child.gameObject.GetComponent<Animator>().Play("slideout");
                    child.gameObject.SetActive(false);
                } 
            }
        }
        else if (model.activeSelf)
        {
            model.GetComponent<Animator>().Play("slideout");
            model.SetActive(false);
        }
    }
	
}
