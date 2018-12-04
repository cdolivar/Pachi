using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectsScript : MonoBehaviour {
    public Sprite remote;
    public Sprite noRemote;
    public Sprite paintingState2;
    public Sprite smallPaintingState2;
    public Sprite otherSmallPaintingState2;
    public Sprite smolLampState2;
    public Sprite largeLamp2;

    private int count;
    private SpriteRenderer spriteRenderer;
    public AudioSource source;

    // only touch once
    private bool hasBeenTouched = false;

    public bool isReusable = false;
    public bool isRemote = false;
    public bool isBatteries = false;
    public bool isKey = false;
    public bool isMayo = false;
    public bool isHotSauce = false;
    public bool isPainting = false;
    public bool isSmallPainting = false;
    public bool isOtherSmallPainting = false;
    public bool isSmolLamp = false;
    public bool isLargeLamp = false;

    // cursor stuff
    public Texture2D cursorTexture;
    public Texture2D cursorTextureOriginal;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // audio stuff
    public AudioClip sound;
    public float vol = 1.0f;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        count = 0;
        source = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update () {

    }

    void OnMouseOver()
    {
        if (isReusable | !hasBeenTouched){
            spriteRenderer.color = Color.yellow;
            Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
    }

    void OnMouseExit()
    {
        spriteRenderer.color = Color.white;
        Cursor.SetCursor(cursorTextureOriginal, hotSpot, cursorMode);
    }


// change sprite on click
void OnMouseDown()
    {
        // don't do anything after being touched once
        if (hasBeenTouched & !isReusable) {
            return;
        }

        // audio
        Debug.Log("playing audio");
        source.PlayOneShot(sound, vol);

        // moving states
        if (isRemote){
            if (count == 0)
            {
                spriteRenderer.sprite = remote;
                count += 1;
            }
            else if (count == 1)
            {
                spriteRenderer.sprite = noRemote;
                globalVariables.setTrue(0);
                hasBeenTouched = true;
            }
        }
        else if (isLargeLamp) {
            spriteRenderer.sprite = largeLamp2;
        }
        else if (isPainting)
        {
            spriteRenderer.sprite = paintingState2;
        }
        else if (isSmallPainting){
            spriteRenderer.sprite = smallPaintingState2;
        }
        else if (isOtherSmallPainting)
        {
            spriteRenderer.sprite = otherSmallPaintingState2;
        }
        else if (isSmolLamp) {
            spriteRenderer.sprite = smolLampState2;
        }
        else if (isBatteries) {
            Destroy(gameObject, sound.length);
            globalVariables.setTrue(4);
        } 
        else if (isKey) {
            Destroy(gameObject, sound.length);
            globalVariables.setTrue(3);
        }
        else if (isMayo) {
            Destroy(gameObject);
            globalVariables.setTrue(1);
        }
        else if (isHotSauce) {
            Destroy(gameObject);
            globalVariables.setTrue(2);
        }
        if (!isRemote){
            hasBeenTouched = true;
        }
    }



}
