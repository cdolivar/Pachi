using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {
    private SpriteRenderer spriteRenderer;
    public Sprite hole;
    public GameObject holeObject;
    public GameObject mayo;
    public GameObject hotsauce;
    public GameObject batteries;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        //spriteRenderer.sprite = hole;
        Destroy(gameObject);
        Destroy(mayo);
        Destroy(hotsauce);
        Destroy(batteries);
        holeObject.SetActive(true);
    }

}
