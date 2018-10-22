using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObjects : MonoBehaviour {
    public bool isRemote;
    public bool isKey;
    public InventoryScript inventory;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown() {
        globalVariables.active = new bool[] { true, false, false, false, false, false };
        inventory.ToggleInventory();
    }
}
