using UnityEngine;
using System.Collections;

public class HouseScript : MonoBehaviour {
	
	private bool collision = false;
	private Inventory inventory;

	private Material material;
	private int built = 1;

	private float maxHeight;
	private float yCenter;

	public int filled = 10;
	public float openDelay = 1.0f;
	public Material open;
	
	// Use this for initialization
	void Start () {
		maxHeight = transform.localScale.y;
		yCenter = transform.localPosition.y;

		inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
		material = gameObject.renderer.material;
		UpdateCrop();
	}
	
	// Update is called once per frame
	void Update () {
		if (collision && Input.GetKeyDown("space"))
		{
			if (built < filled && inventory.BrickCount > 0) {
				--inventory.BrickCount;
				++built;
				UpdateCrop();
			} else if (openDelay == 0.0f) {
				// Load Win Screen
			}
		}
	}

	void FixedUpdate () {
		if (built >= filled && openDelay > 0.0f) {
			openDelay -= Time.fixedDeltaTime;
			if (openDelay <= 0.0f) {
				openDelay = 0.0f;
				renderer.material = open;
			}
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
		transform.localPosition = new Vector3(transform.localPosition.x, (scale * maxHeight / 2.0f) + yCenter, transform.localPosition.z);
	}
}
