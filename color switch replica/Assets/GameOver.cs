using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	Animator anim;
	float restartTimer;
	public float restartDelay = 5f;

	void Awake () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerController.win == true) {
			Debug.Log ("TRUE");
			anim.SetTrigger ("IsGameOver");
			restartTimer += Time.deltaTime;
			if (restartTimer >= restartDelay) {
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
}
