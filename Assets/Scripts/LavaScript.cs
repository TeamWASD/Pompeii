using UnityEngine;
using System.Collections;

public class LavaScript : MonoBehaviour {

	public Vector2 startSize, endSize;
	private float t = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		transform.localScale = Vector2.Lerp (startSize, endSize, t += 0.01f);
	}
}
