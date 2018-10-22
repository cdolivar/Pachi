using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class InventoryScript : MonoBehaviour {
    public Image inventoryBox;
    public Button inventoryButton;
    public GameObject fire;
    public GameObject batteriesInFire;
    private bool inventoryShowing;

    private Image[] items;
    public Image remote;
    public Image mayo;
    public Image hotSauce;
    public Image fireKey;
    public Image batteries;

    // Use this for initialization
    void Start () {
        inventoryShowing = false;
        fire.GetComponent<Renderer>().enabled = false;
        batteriesInFire.GetComponent<Renderer>().enabled = false;
        HideInventoryBox();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleInventory() {
        if (inventoryShowing) {
            HideInventoryBox();
            inventoryShowing = false;
        }
        else {
            ShowInventoryBox();
            inventoryShowing = true;
        }
    }

    public void ShowInventoryBox(){
        inventoryBox.enabled = true;
        Image[] items = new Image[] { remote, mayo, hotSauce, fireKey, batteries };
        for (int i = 0; i < items.Length; i++)
        {
            if (globalVariables.inventory[i]){
                items[i].enabled = true;
            }
        }
    }

    public void HideInventoryBox()
    {
        inventoryBox.enabled = false;

        Image[] items = new Image[] { remote, mayo, hotSauce, fireKey, batteries };
        for (int i = 0; i < items.Length; i++)
        {
            //Debug.Log("hiding something");
            items[i].enabled = false;
        }
    }

    public void ShowButton() {
        inventoryButton.gameObject.SetActive(true);
    }

    public void HideButton()
    {
        inventoryButton.gameObject.SetActive(false);
    }
}
