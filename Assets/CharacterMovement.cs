using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	//public : Iedereen kan hierbij komen. Hij komt dan ook in de Unity Inspector te staan.
	public float movementSpeed = 10f;
	public float jumpSpeed 	   = 10f;
	Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {

		rigidBody = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
			
		//Jump
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rigidBody.velocity = new Vector2 (0,jumpSpeed);
		}

		//Walk
		Vector2 input = new Vector2(Input.GetAxis("Horizontal"),0);


	//New Vector2 is x en y. Als je een 60 fps game wil runnen moet je 60:1000 doen. Meestal doet Unity dat automatisch. 
	//rigidBody.velocity = new Vector2 (movementSpeed, 0);
		rigidBody.velocity = input * movementSpeed;
		rigidBody.drag = 10;

	
	}
}
