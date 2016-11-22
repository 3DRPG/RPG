using UnityEngine;
using System.Collections;

public class playerView : MonoBehaviour {


    private Rigidbody rb;
    


    public enum Movement {
            STILL = 0,
            FORWARD = 1 ,
            BACKWARD =2 ,
            RIGHT =3 ,
            LEFT = 4
    };
	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}

    public void move(Movement movment ,float _velocity)
    {
        Vector3 position = Vector3.zero;
        switch (movment)
        {
            case Movement.FORWARD:
                position = rb.transform.forward * _velocity;
                break;


            case Movement.BACKWARD:
                position = rb.transform.forward *-1 * _velocity;
                break;



            case Movement.LEFT:
                position = Vector3.Cross(rb.transform.forward, rb.transform.up) * _velocity;
                break;


            case Movement.RIGHT:
                position = Vector3.Cross(rb.transform.forward, rb.transform.up) * -1 * _velocity;
                break;




        }

        rb.MovePosition(rb.position + position * Time.fixedDeltaTime);

    }



    public void rotate(Vector3 amount)
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(amount));
    }
}
