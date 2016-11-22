using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {

    private float yRot;
    private float xRot;


    private playerView pView;
    // Use this for initialization
    void Start () {
        pView = FindObjectOfType<playerView>();
    }
	
	// Update is called once per frame
	void Update () {

        

        if (Input.GetMouseButtonDown(0))
            Debug.Log("left click");

        else if (Input.GetMouseButton(1))
        {
            Debug.Log("right click");
            xRot = Input.GetAxisRaw("Mouse X");
            yRot = Input.GetAxisRaw("Mouse Y");

            pView.rotate(new Vector3(0, xRot,0));
            

            Debug.Log("x-->" + xRot);
            Debug.Log("y-->" + yRot);
        }


    }
}
