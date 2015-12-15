using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// SHould read off the setttings
	public static float PLAYER_SPEED = 3f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float rotateX = -Input.acceleration.x;
		rotateX = rotateX > 0 ? rotateX + PLAYER_SPEED : rotateX - PLAYER_SPEED;

		this.transform.rotation *= Quaternion.Euler(0, 0, rotateX);
	}


}
