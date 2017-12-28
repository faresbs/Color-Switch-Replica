using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float jumpForce = 10f;

	private Rigidbody2D body2d;

	public string currentColor;

	public SpriteRenderer playerColor;

	public Color colorCyan;
	public Color colorYellow;
	public Color colorPurple;
	public Color colorPink;
	public Color colorBlack;

	public death playerDeath;

	public static bool win;

	// Use this for initialization
	void Start () {
		body2d = gameObject.GetComponent<Rigidbody2D> ();
		setRandomColor();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKey) 
		{
			body2d.velocity = Vector2.up * jumpForce;
		}

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "colorChanger") {
			setRandomColor ();
			Destroy (other.gameObject);
			Debug.Log ("Hit!");
			return;
		}

		if (other.tag == "cyan") {
			if (currentColor == "Cyan") {
			} else {
				playerColor.color = colorBlack;
				gameOver ();
			}
		}

		if (other.tag == "yellow") {
			if (currentColor == "Yellow") {
			} else {
				playerColor.color = colorBlack;
				gameOver ();
			}	
		}

		if (other.tag == "purple") {
			if (currentColor == "Purple") {
			} else {
				playerColor.color = colorBlack;
				gameOver ();
			}	
		}

		if (other.tag == "pink") {
			if (currentColor == "Pink") {
			} else {
				playerColor.color = colorBlack;
				gameOver ();
			}	
		}

		if (other.tag == "Limit") {
			gameOver ();
			Debug.Log ("DEAD");
		}

		if (other.tag == "end") {
			win = true;
			Debug.Log ("WIN");
		} else {
			win = false;
		}

	}

	void setRandomColor(){
		int index = Random.Range (0, 4);

		switch (index) {
		case 0:
			currentColor = "Cyan";
			playerColor.color = colorCyan;
			break;
		case 1:
			currentColor = "Yellow";
			playerColor.color = colorYellow;
			break;
		case 2:
			currentColor = "Pink";
			playerColor.color = colorPink;
			break;
		case 3:
			currentColor = "Purple";
			playerColor.color = colorPurple;
			break;
		}
	}

	void gameOver(){
		death.deaths++;
		Application.LoadLevel (Application.loadedLevel);
	}
}
