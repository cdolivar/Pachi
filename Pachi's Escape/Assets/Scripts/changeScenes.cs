using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScenes : MonoBehaviour {
    public Transform camera;
    public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
        Debug.Log("neither");
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
