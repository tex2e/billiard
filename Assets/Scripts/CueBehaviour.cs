using UnityEngine;
using System.Collections;

public class CueBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKey("up")) {
			transform.Translate(Vector3.up * 0.1f);
		} else if (Input.GetKey("down")) {
			transform.Translate(Vector3.down * 0.1f);
		}
	}
}
