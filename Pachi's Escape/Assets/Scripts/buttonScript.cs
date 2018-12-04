using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour {
    public Transform camera;
    public int speed;
    public bool leftButton;
    public AudioClip walkingSound;
    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver() {
        Debug.Log("hovering over!!!");
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
