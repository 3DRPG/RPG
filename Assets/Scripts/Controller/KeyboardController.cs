using UnityEngine;
using System.Collections;

public class KeyboardController : MonoBehaviour {
    [SerializeField]
    private Animator arraAnimationController;

    private playerView pView;

	// Use this for initialization
	void Start () {
        pView = FindObjectOfType<playerView>();
	}
	
	// Update is called once per frame
	void Update () {

        // When W is pressed
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("W is pressed");
            
            if (Input.GetKey(KeyCode.LeftShift))
            {
                arraAnimationController.SetBool("isShiftPressed", true);
                pView.move(playerView.Movement.FORWARD, 20);
                Debug.Log("RUN");
            }

            else
            {
                arraAnimationController.SetBool("isWPress", true);
                pView.move(playerView.Movement.FORWARD, 5);
                arraAnimationController.SetBool("isShiftPressed", false);

            }
        }


        // When A is pressed
        else if (Input.GetKey(KeyCode.A))
        {

            if (Input.GetKey(KeyCode.LeftShift))
            {
                arraAnimationController.SetBool("isShiftPressed", true);
                pView.move(playerView.Movement.LEFT, 20);
                Debug.Log("RUN");
            }

            else
            {
                arraAnimationController.SetBool("isAPress", true);
                pView.move(playerView.Movement.LEFT, 5);
                arraAnimationController.SetBool("isShiftPressed", false);

            }
        }

        // When S is pressed
        else if (Input.GetKey(KeyCode.S))
        {
           
                arraAnimationController.SetBool("isSPress", true);
                pView.move(playerView.Movement.BACKWARD, 5);
                //arraAnimationController.SetBool("isShiftPressed", false);

            

        }

        // When D is pressed
        else if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                arraAnimationController.SetBool("isShiftPressed", true);
                pView.move(playerView.Movement.RIGHT, 20);
                Debug.Log("RUN");
            }

            else
            {
                arraAnimationController.SetBool("isDPress", true);
                pView.move(playerView.Movement.RIGHT, 5);
                arraAnimationController.SetBool("isShiftPressed", false);

            }
        }

        // When Space is pressed
        else if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("W is pressed");
            arraAnimationController.SetBool("isSpacePress", true);

        }

        

        // when nothin is pressed
        else
        {
            arraAnimationController.SetBool("isWPress", false);
            arraAnimationController.SetBool("isAPress", false);
            arraAnimationController.SetBool("isDPress", false);
            arraAnimationController.SetBool("isSPress", false);
            arraAnimationController.SetBool("isSpacePress", false);
            arraAnimationController.SetBool("isShiftPressed", false);

        }




    }
}
