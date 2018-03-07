using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour {

	public float runSpeed = 5.0f;
	public Transform groundCheck;
	public float groundCheckRadius = 0.2f;
	public LayerMask whatIsGround;

	private Rigidbody2D rBody;
	private SpriteRenderer sRend;
	private Animator anim;
	private bool isGrounded;
	private float moveHorizontal;

	// Use this for initialization
	void Start () {
		rBody = GetComponent<Rigidbody2D>();
		sRend = GetComponent<SpriteRenderer>();
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void FixedUpdate() {
		runToTheRight ();
	}

	void runToTheLeft(){
		moveHorizontal = 0.5f;
		anim.SetFloat("Speed", Mathf.Abs(moveHorizontal));

		rBody.velocity = new Vector2(moveHorizontal * runSpeed, rBody.velocity.y);
		sRend.flipX = false;
	}

	void runToTheRight(){
		moveHorizontal = -0.5f;
		anim.SetFloat("Speed", Mathf.Abs(moveHorizontal));

		rBody.velocity = new Vector2(moveHorizontal * runSpeed, rBody.velocity.y);
		sRend.flipX = true;
	}
}
