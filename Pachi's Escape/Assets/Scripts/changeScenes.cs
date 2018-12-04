using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScenes : MonoBehaviour {
    public Transform camera;
    public int speed;

    // cursor stuff
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Use this for initialization
    void Start () {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }
	
	// Update is called once per frame
	void Update () {
        //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        if (Input.GetKey(KeyCode.RightArrow) && camera.gameObject.transform.position.x < 26.43)
        {
            PanRight();
        }
        if (Input.GetKey(KeyCode.LeftArrow) && camera.gameObject.transform.position.x > 0)
        {
            PanLeft();
        }
    }
    public void JumpToDrawer()
    {
        camera.Translate(new Vector3(28, -11, 0));
    }


    public void PanLeft()
    {
        camera.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
    }

    public void PanRight()
    {
        camera.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
    }


}
