using UnityEngine;
using System.Collections;

public class Pickupable : MonoBehaviour {

	private bool collision = false;
	private Inventory inventory;

	// Use this for initialization
	void Start () {
		inventory = GameObject.FindWithTag ("Player").GetComponent<Inventory> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (collision && Input.GetButtonDown("Use") && inventory.RockCount < 5)
		{
			inventory.RockCount++;
			collision = false;
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.tag.Equals("Player"))
		{
			collision = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D otherCollider)
	{
		collision = false;
	}
}
