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

    GameObject collisionObj;
    private bool rockCollision = false;
    private int rockCount = 0;
	
	// 2 - Store the movement
	private Vector2 movement;
	
	void Update()
	{
		// 3 - Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

        Debug.Log("Rocks: " + rockCount);

        if (collisionObj != null && Input.GetKeyDown("space") && collisionObj.gameObject.tag.Equals("Rock"))
	    {
	        Destroy(collisionObj);
	        rockCount++;
	        collisionObj = null;
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
        if (otherCollider.gameObject.tag.Equals("Rock"))
        {
            collisionObj = otherCollider.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D otherCollider)
    {
        collisionObj = null;
    }
}