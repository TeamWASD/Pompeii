using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {

	private bool collision = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
