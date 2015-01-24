using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private float rightBound;
	private float leftBound;
	private float topBound;
	private float bottomBound;

	private Transform target;
	private Transform follow;
	private SpriteRenderer spriteBounds;

	// Use this for initialization
	void Start () {
		float vertExtent = Camera.main.camera.orthographicSize;  
		float horzExtent = vertExtent * Screen.width / Screen.height;

		target = GameObject.Find("Player").transform;
		follow = GameObject.Find ("Main Camera").transform;

		spriteBounds = GameObject.Find("Background").GetComponentInChildren<SpriteRenderer>();

		leftBound = (float)(horzExtent - spriteBounds.sprite.bounds.size.x / 2.0f);
		rightBound = (float)(spriteBounds.sprite.bounds.size.x / 2.0f - horzExtent);
		bottomBound = (float)(vertExtent - spriteBounds.sprite.bounds.size.y / 2.0f);
		topBound = (float)(spriteBounds.sprite.bounds.size.y  / 2.0f - vertExtent);
	}
	
	// Update is called once per frame
	void Update () {
		var pos = new Vector3(follow.position.x, follow.position.y, 0);
		pos.x = Mathf.Clamp(pos.x, leftBound, rightBound);
		pos.y = Mathf.Clamp(pos.y, bottomBound, topBound);
		target.position = pos;
	}
}
