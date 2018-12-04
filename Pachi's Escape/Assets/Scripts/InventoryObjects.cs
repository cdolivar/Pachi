using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObjects : MonoBehaviour {
    public bool isRemote;
    public bool isKey;
    public bool isBatteries;
    public bool isMayo;
    public bool isHotSauce;
    public InventoryScript inventory;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnMouseDown() {
        if (isRemote) {
            globalVariables.active = new bool[] { true, false, false, false, false, false };
            inventory.ToggleInventory();
        }
        if (isKey) {
            globalVariables.active = new bool[] { false, false, false, true, false, false };
            inventory.ToggleInventory();
        }
        if (isBatteries) {
            globalVariables.active = new bool[] { false, false, false, false, true, false };
            inventory.ToggleInventory();
        }
        if (isMayo)
        {
            globalVariables.active = new bool[] { false, true, false, false, false, false };
            inventory.ToggleInventory();
        }
        if (isHotSauce) {
            globalVariables.active = new bool[] { false, false, true, false, false, false };
            inventory.ToggleInventory();
        }
    }
}
