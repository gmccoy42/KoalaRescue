using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

	private bool isFalling;
	// Use this for initialization
	void Start () 
	{
		isFalling = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float movespeed = 0.007f;
		transform.position = new Vector3(transform.position.x + movespeed, transform.position.y);
		transform.Translate(movespeed, 0, 0);

		if (Input.GetKeyDown(KeyCode.Space) && isFalling == false)
		{
			Debug.Log("Jump!");
			rigidbody2D.AddForce(new Vector2(0f, 250f));
			isFalling = true;
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		Debug.Log("Collision Detected");
		isFalling = false;
	}
}
