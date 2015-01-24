using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// Player controller and behavior
/// </summary>
public class MoveScript : MonoBehaviour
{
	/// <summary>
	/// 1 - The speed of the ship
	/// </summary>
	public Vector2 speed = new Vector2(50, 50);

    private bool rockCollision = false;
    private bool hasRock = false;
	
	// 2 - Store the movement
	private Vector2 movement;
	
	void Update()
	{
		// 3 - Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

	    if (Input.GetKeyDown("space") && rockCollision && (!hasRock))
	    {
	        rockCollision = false;
	        hasRock = true;
            Debug.Log("You picked up a rock.");
	    }
		
		// 4 - Movement per direction
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);
		
	}
	
	void FixedUpdate()
	{
		// 5 - Move the game object
		rigidbody2D.velocity = movement;
	}

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.gameObject.name.Equals("Rock"))
        {
            rockCollision = true;
        }
    }
}
