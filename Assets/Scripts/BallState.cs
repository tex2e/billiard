using UnityEngine;
using System;
using System.Collections;
using System.Linq;

public class BallState : MonoBehaviour {

	// balls[0] = cueBall
	// balls[1..] = objectBall
	public GameObject[] balls = new GameObject[10];

	public bool allBallsStoped = true;

	// Use this for initialization
	void Start() {
		//
	}

	// Update is called once per frame
	void Update() {
		this.allBallsStoped =
			balls.All(ball => ball.GetComponent<Rigidbody>().velocity.magnitude <= 0.1);
	}
}
