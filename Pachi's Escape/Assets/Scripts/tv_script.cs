using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv_script : MonoBehaviour {
    public Sprite tv_on;

    private int count;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        count = 0;
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
            spriteRenderer.sprite = tv_on;
            count += 1;
            globalVariables.active = new bool[] {false, false, false, false, false, false};
            globalVariables.inventory[0] = false;
}
    }
}
