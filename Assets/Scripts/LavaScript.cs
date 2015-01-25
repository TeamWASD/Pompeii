using UnityEngine;
using System.Collections;

public class LavaScript : MonoBehaviour {

	public Vector2 startSize, endSize;
	public float deltaFactor = 0.2f, Cooldown = 1.0f;
	private float t = 0.0f, _cooldown = 0.0f;
	private bool grow = true, collision = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (grow) {
			t += Time.deltaTime * deltaFactor;
			if (t >= 1.0f) {
				t = 1.0f;
				grow = false;
			}
			Vector2 scale = new Vector2 (
				QuadLerp (startSize.x, endSize.x, t),
				QuadLerp (startSize.y, endSize.y, t)
				);
			transform.localScale = scale;
		}
	}

	void FixedUpdate () {
		if (_cooldown > 0.0f) {
			_cooldown -= Time.fixedDeltaTime;
			if (_cooldown < 0.0f) _cooldown = 0.0f;
		}
		if (collision && _cooldown == 0.0f) {
			GameObject player = GameObject.FindWithTag("Player");
			Inventory inventory = player.GetComponent<Inventory>();
			if (inventory.RockCount > 0) {
				if (inventory.BrickCount > 0) {
					if (Random.Range(0, 1) == 1)
						--inventory.BrickCount;
					else
						--inventory.RockCount;
				} else
					--inventory.RockCount;
			} else if (inventory.BrickCount > 0)
				--inventory.BrickCount;
			else
				Application.LoadLevel("LoseScene");
			_cooldown = Cooldown;
			inventory.Cooldown = _cooldown;
		}
	}

	float QuadLerp (float a1, float a2, float t) {
		return Mathf.Sqrt ((a2 * a2 * t) + (a1 * a1 * (1.0f - t)));
	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.tag.Equals("Player")) collision = true;
	}
	
	void OnTriggerExit2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.tag.Equals("Player")) collision = false;
	}

}
