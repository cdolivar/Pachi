using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalVariables : MonoBehaviour {
    public static int position;
    // remote, mayo, hot sauce, key, batteries
    public static bool[] inventory = new bool[] { false, false, false, false, false, false };
    public static bool[] active = new bool[] { false, false, false, false, false, false };
    // fire, mayo, hot sauce batteries
    public static bool[] explosiveItems = new bool[] {false, false, false, false};
    public static bool canPan = true;

    // Use this for initialization
    void Start () {
        position = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void setTrue(int index) {
        inventory[index] = true;
    }

    public static void setFalse(int index)
    {
        inventory[index] = false;
    }
}
