﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillowScript : MonoBehaviour {
    public Sprite remote;
    public Sprite noRemote;
    private int count;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        count = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // change sprite on click
    void OnMouseDown()
    {   
        if (count == 0) {
            spriteRenderer.sprite = remote;
            count += 1;
        }
        else if (count == 1) {
            spriteRenderer.sprite = noRemote;
            globalVariables.setTrue(0);
        }

    }



}
