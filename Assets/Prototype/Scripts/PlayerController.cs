using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	AnimationState animationState;
	Time  			animationTime;

	SpriteRenderer spriteRenderer;

	//Movement
	public float speed = 	10f;
	public float jump = 	10f;
	float moveVelocity = 	3f;

	//Grounded Vars
	bool isGrounded = true;

	//Sprites
	public Sprite jumpUpSprite;
	public Sprite JumpMidSprite;
	public Sprite jumpDownSprite;

	public Sprite idleSprite;
	public Sprite walkSprite;

	public Sprite attack1Sprite;
	public Sprite attack2Sprite;


	void Start ()
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = idleSprite;

	}


	void Update () 
	{
		//Terug naar Idle switchen wanneer je niks doet
		if(isGrounded)
		spriteRenderer.sprite = idleSprite;


		//Jumping
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Z) || Input.GetKeyDown (KeyCode.W)) 
		{
			if(isGrounded)
			{
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.y, jump);
				isGrounded = false;
				spriteRenderer.sprite = jumpUpSprite;
			}

				transform.rotation = Quaternion.Euler(0f, -180f, 0f);

			if (!isGrounded && moveVelocity < 0)
				spriteRenderer.sprite = JumpMidSprite;

			if (!isGrounded && moveVelocity > 0)
				spriteRenderer.sprite = JumpMidSprite;
		}

		//Dit zorgt ervoor dat je stopt. 
		moveVelocity = 0;



		
		//Left Right Movement
		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
		{
			transform.rotation = Quaternion.Euler(0f, -180f, 0f);
	
			moveVelocity = -speed;
			if (isGrounded) {
				
				spriteRenderer.sprite = walkSprite;
			}
		}
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
		{
			transform.rotation = Quaternion.Euler(0f, 0f, 0f);

			moveVelocity = speed;
			if (isGrounded) {
				
				spriteRenderer.sprite = walkSprite;
			}
		}

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);

		//Attack animations
		if (Input.GetKey (KeyCode.V))
		{
			//animationTime = 20; 
			//spriteRenderer.sprite = attack1Sprite;

		}
			
					
					
		}
	//Check if Grounded

	void OnCollisionEnter2D()
		{
		isGrounded = true;
	}
}