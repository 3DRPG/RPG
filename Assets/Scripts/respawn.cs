using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {
	
	private Vector3 startPos;
	private Quaternion startRot;
	
	// Use this for initialization
	void Start () {
		startPos = transform.position;
		startRot = transform.rotation;
	}

	//Detect collision with collider DeathZone
	void OnTriggerEnter(Collider col) {
		if (col.tag == "DeathZone") {
			transform.position = startPos;
			transform.rotation = startRot;

			GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
			GetComponent<Rigidbody>().angularVelocity = new Vector3(0,0,0);


		} else if (col.tag == "checkpoint"){
			startPos = col.transform.position;
			startRot = col.transform.rotation;
		}
	}

}
