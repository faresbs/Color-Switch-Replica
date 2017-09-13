using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class death : MonoBehaviour {

	public static int deaths = 0;

	Text deathText;

	// Use this for initialization
	void Start () {
		deathText = GetComponent<Text> ();
		deathText.text = "Deaths : " + deaths;
	}
	
	// Update is called once per frame
	void Update () {
		deathText.text = "Deaths : " + deaths;
	}
}
