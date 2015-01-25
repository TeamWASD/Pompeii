using UnityEngine;
using System.Collections;

public class HouseScript : MonoBehaviour {
	
	private bool collision = false;
	private Inventory inventory;

	private Material material;
	private int built = 1;

	public float maxHeight = 1.79f;
	public int filled = 10;
	
	// Use this for initialization
	void Start () {
		inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
		material = gameObject.renderer.material;
		UpdateCrop();
	}
	
	// Update is called once per frame
	void Update () {
		if (collision && built < filled && Input.GetKeyDown("space") && inventory.BrickCount > 0)
		{
			--inventory.BrickCount;
			++built;
			UpdateCrop();
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

	void UpdateCrop() {
		float scale = (float) built / filled;
		material.mainTextureScale = new Vector2(material.mainTextureScale.x, scale);
		transform.localScale = new Vector3(transform.localScale.x, scale * maxHeight, transform.localScale.z);
		transform.localPosition = new Vector3(transform.localPosition.x, scale * maxHeight / 2.0f, transform.localPosition.z);
	}
}
