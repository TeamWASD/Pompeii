using UnityEngine;
using System.Collections;

public class RemoveHouse : MonoBehaviour {
	private bool collision = false;
	private HouseScript house;

	// Use this for initialization
	void Start () {
		house = GameObject.FindWithTag ("House").GetComponent<HouseScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (collision && Input.GetButtonDown("Use"))
		{
			house.Trigger ();
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
