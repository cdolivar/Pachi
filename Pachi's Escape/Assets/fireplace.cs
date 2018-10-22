using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireplace : MonoBehaviour {
    public GameObject fire;
    public GameObject batteriesInFire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (globalVariables.active[3]){ // key
            fire.GetComponent<Renderer>().enabled = true;
            globalVariables.active = new bool[] { false, false, false, false, false, false };
            globalVariables.inventory[3] = false;
        }
        if (globalVariables.active[4]) { // batteries
            batteriesInFire.GetComponent<Renderer>().enabled = true;
            globalVariables.active = new bool[] { false, false, false, false, false, false };
            globalVariables.inventory[4] = false;
        }
    }
}
