using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private float rightBound;
	private float leftBound;
	private float topBound;
	private float bottomBound;

	private Transform follow;

	// Use this for initialization
	void Start () {
		float vertExtent = Camera.main.camera.orthographicSize;  
		float horzExtent = vertExtent * Screen.width / Screen.height;

		follow = GameObject.FindWithTag("Player").transform;

		Renderer background = GameObject.Find("Background").renderer;

		leftBound = (float)(background.bounds.min.x + horzExtent);
		rightBound = (float)(background.bounds.max.x - horzExtent);
		bottomBound = (float)(background.bounds.min.x + vertExtent);
		topBound = (float)(background.bounds.max.x - vertExtent);
	}
	
	// Update is called once per frame
	void Update () {
		var pos = new Vector3(follow.position.x, follow.position.y, -10);
		pos.x = Mathf.Clamp(pos.x, leftBound, rightBound);
		pos.y = Mathf.Clamp(pos.y, bottomBound, topBound);
		this.transform.position = pos;
	}
}
