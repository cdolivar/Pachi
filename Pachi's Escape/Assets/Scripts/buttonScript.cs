using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {
    public Transform camera;
    public int speed;
    public bool leftButton;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver() {
        if (globalVariables.canPan){
            if (camera.gameObject.transform.position.x > 0 && leftButton)
            {
                camera.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            }
            else if (camera.gameObject.transform.position.x < 26.43 && !leftButton)
            {
                camera.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }
    }
}
