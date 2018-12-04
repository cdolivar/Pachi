using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireplace : MonoBehaviour {
    public GameObject fire;
    public GameObject batteriesInFire;
    public GameObject hotSauceInFire;
    public GameObject mayonaiseInFire;
    public GameObject explosion;
    public GameObject hole;
    public AudioSource source;
    public AudioClip sound;
    public AudioClip matchLight;
    public AudioClip crackle;
    public AudioClip placeInFireplace;
    public float vol = 1.0f;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        bool[] explosives = globalVariables.explosiveItems;
        if (explosives[0] && explosives[1] && explosives[2] && explosives[3])
        {

            globalVariables.explosiveItems = new bool[] { false, false, false, false };

            //Destroy(gameObject);
            Destroy(mayonaiseInFire);
            Destroy(hotSauceInFire);
            Destroy(batteriesInFire);

            Debug.Log("4");
            Invoke("testing", (float) .5);
            Debug.Log("5");


            Debug.Log("6");


            //Vector3 temp = new Vector3((float) -5.18f, (float) -1.51f, (float) -2.26);
            //gameObject.transform.position = temp;
        }
    }
    void testing(){
        //explosion.GetComponent<Renderer>().enabled = true;
        explosion.SetActive(true);
        source.PlayOneShot(sound, vol);
        Destroy(fire);

        hole.SetActive(true);
        Invoke("GoAwayExplosion", (float) 1.5 );
    }

    void GoAwayExplosion() {
        Destroy(gameObject);
        Debug.Log("go away explosion");
        Destroy(explosion);
    }


    void OnMouseDown() // fire, mayo, hot sauce batteries in global explosives
    {
        // play sound when placing objcts in fireplace
        if (globalVariables.active[4] || globalVariables.active[5] || globalVariables.active[2] || globalVariables.active[1]){
            source.PlayOneShot(placeInFireplace);
        }
        if (globalVariables.active[3]){ // fire 
            //fire.GetComponent<Renderer>().enabled = true;
            fire.SetActive(true);
            globalVariables.explosiveItems[0] = true;
            globalVariables.active = new bool[] { false, false, false, false, false, false };
            globalVariables.inventory[3] = false;
            source.PlayOneShot(matchLight);
            source.loop = true;
            source.PlayOneShot(crackle);
        }
        if (globalVariables.active[4]) { // batteries
            //batteriesInFire.GetComponent<Renderer>().enabled = true;
            batteriesInFire.SetActive(true);
            globalVariables.explosiveItems[3] = true;
            globalVariables.active = new bool[] { false, false, false, false, false, false };
            globalVariables.inventory[4] = false;
        }
        if (globalVariables.active[2]){ // hot sauce
            //hotSauceInFire.GetComponent<Renderer>().enabled = true;
            hotSauceInFire.SetActive(true);
            globalVariables.explosiveItems[2] = true;
            globalVariables.active = new bool[] { false, false, false, false, false, false };
            globalVariables.inventory[2] = false;
        }
        if (globalVariables.active[1]) // mayo
        {

            //mayonaiseInFire.GetComponent<Renderer>().enabled = true;
            mayonaiseInFire.SetActive(true);
            globalVariables.explosiveItems[1] = true;
            globalVariables.active = new bool[] { false, false, false, false, false, false };
            globalVariables.inventory[1] = false;
        }
    }
}
