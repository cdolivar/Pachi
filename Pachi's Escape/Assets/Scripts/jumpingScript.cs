using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpingScript : MonoBehaviour {
    public Transform camera;
    public bool fromKitchenToDrawer = false;
    public bool ToKitchen = false;
    public bool fromKitchenToFridge = false;
    public SpriteRenderer spriteRenderer;

    // sound stuff
    private AudioSource source;
    float vol = 1.0f;
    public AudioClip sound;


    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver()
    {
        spriteRenderer.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = Color.white;
    }



    void OnMouseDown() {
        source.PlayOneShot(sound, vol);
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
