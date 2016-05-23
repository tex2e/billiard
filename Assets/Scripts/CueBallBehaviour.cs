using UnityEngine;
using System.Collections;

public class CueBallBehaviour : MonoBehaviour {
	public Rigidbody rb;

	// Use this for initialization
	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update() {
		float speed = 12000;
		if (Input.GetKeyDown("up")) {
			rb.AddForce(Vector3.left * speed);
		}
	}
}
