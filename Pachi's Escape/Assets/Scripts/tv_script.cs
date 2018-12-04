using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv_script : MonoBehaviour {
    public Sprite tv_on;
    public AudioClip tv_audio;
    public Animator anim;
    private AudioSource source;
    private int count;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        count = 0;
        source = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // change sprite on click
    void OnMouseDown()
    {
        if ((count == 0) && (globalVariables.active[0]))
        {
            source.PlayOneShot(tv_audio, 2.0f);
            //spriteRenderer.sprite = tv_on;
            count += 1;
            anim.Play("tv");
            globalVariables.active = new bool[] {false, false, false, false, false, false};
            globalVariables.inventory[0] = false;
}
    }
}
