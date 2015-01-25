using UnityEngine;
using System.Collections;

public class Workable : MonoBehaviour {

    private bool collision = false;
    private Inventory inventory;

	// Use this for initialization
	void Start () {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
	}
	
	// Update is called once per frame
	void Update () {
        if (collision && Input.GetButtonDown("Use") && inventory.RockCount > 0 && inventory.BrickCount < 5)
        {
            inventory.RockCount--;
            inventory.BrickCount++;
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
