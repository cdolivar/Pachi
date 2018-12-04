using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class InventoryScript : MonoBehaviour {
    public Image inventoryBox;
    public Button inventoryButton;
    public GameObject fire;
    public GameObject batteriesInFire;
    public GameObject hotSauceInFire;
    public GameObject mayonaiseInFire;
    public GameObject explosion;
    public GameObject hole;
    public AudioClip clickAudio;
    private bool inventoryShowing;

    private Image[] items;
    public Image remote;
    public Image mayo;
    public Image hotSauce;
    public Image fireKey;
    public Image batteries;
    // sound 
    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start () {
        inventoryShowing = false;
        //fire.GetComponent<Renderer>().enabled = false;
        fire.SetActive(false);
        //batteriesInFire.GetComponent<Renderer>().enabled = false;
        batteriesInFire.SetActive(false);
        //hotSauceInFire.GetComponent<Renderer>().enabled = false;
        hotSauceInFire.SetActive(false);
        //mayonaiseInFire.GetComponent<Renderer>().enabled = false;
        mayonaiseInFire.SetActive(false);
        //explosion.GetComponent<Renderer>().enabled = false;
        explosion.SetActive(false);
        //hole.GetComponent<Renderer>().enabled = false;
        hole.SetActive(false);
        HideInventoryBox();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleInventory() {
        source.PlayOneShot(clickAudio, 1.0f);
        if (inventoryShowing) {
            HideInventoryBox();
            inventoryShowing = false;
        }
        else {
            ShowInventoryBox();
            inventoryShowing = true;
        }
    }

    public void ShowInventoryBox(){
        inventoryBox.enabled = true;
        Image[] items = new Image[] { remote, mayo, hotSauce, fireKey, batteries };
        for (int i = 0; i < items.Length; i++)
        {
            if (globalVariables.inventory[i]){
                items[i].gameObject.SetActive(true);
            }
            //items[i].gameObject.SetActive(true); // sets all invetory to true
        }
    }

    public void HideInventoryBox()
    {
        inventoryBox.enabled = false;

        Image[] items = new Image[] { remote, mayo, hotSauce, fireKey, batteries };
        for (int i = 0; i < items.Length; i++)
        {
            //Debug.Log("hiding something");
            //items[i].enabled = false;
            items[i].gameObject.SetActive(false);
        }
    }

    public void ShowButton() {
        inventoryButton.gameObject.SetActive(true);
    }

    public void HideButton()
    {
        inventoryButton.gameObject.SetActive(false);
    }
}
