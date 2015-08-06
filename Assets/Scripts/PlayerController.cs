using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float jumpHeight;
	public float moveSpeed;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
				GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
	    }
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
}
