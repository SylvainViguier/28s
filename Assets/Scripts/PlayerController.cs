using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	// Variables
	public float jumpHeight;
	public float moveSpeedInc = 1;
	public float moveSpeedMax = 3;
	public bool isjumping;
	
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update ()
	{
		//Jump
		if (Input.GetKey(KeyCode.UpArrow)&& (!isjumping))
		{
			isjumping = true;	
			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
		}
		
		//Move Forward
		if ((Input.GetKey(KeyCode.RightArrow)) && (GetComponent<Rigidbody2D>().velocity.x < moveSpeedMax))
		{
			GetComponent<Rigidbody2D>().velocity += new Vector2(moveSpeedInc, 0);
		}
		
		//Move Backward
		if ((Input.GetKey(KeyCode.LeftArrow)) && (GetComponent<Rigidbody2D>().velocity.x > -moveSpeedMax))
		{
			GetComponent<Rigidbody2D>().velocity += new Vector2(-moveSpeedInc, 0);
		}
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		isjumping = false;
	}
}
