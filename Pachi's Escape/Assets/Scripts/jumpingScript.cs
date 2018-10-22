using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpingScript : MonoBehaviour {
    public Transform camera;
    public bool fromKitchenToDrawer = false;
    public bool ToKitchen = false;
    public bool fromKitchenToFridge = false;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown() {
        // Jump to drawer 
        if (fromKitchenToDrawer)
        {
            camera.position = new Vector3(28, -11, (float)-12.94);
            globalVariables.canPan = false;
        }
        else if (ToKitchen) {
            camera.position = new Vector3(26, 0, (float)-12.94);
            globalVariables.canPan = true;
        }
        else if (fromKitchenToFridge) {
            camera.position = new Vector3(45, -11, (float)-12.94);
            globalVariables.canPan = false;
        }
    }
}
