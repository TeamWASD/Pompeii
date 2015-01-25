﻿using UnityEngine;
using System.Collections;

public class LavaScript : MonoBehaviour {

	public Vector2 startSize, endSize;
	public float deltaT;
	private float t = 0.0f;
	private bool grow = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		if (grow) {
			Vector2 scale = new Vector2 (
				QuadLerp (startSize.x, endSize.x, t),
				QuadLerp (startSize.y, endSize.y, t)
						);
			transform.localScale = scale;
			t += deltaT;
			if (t >= 1.0f) {
					t = 1.0f;
					grow = false;
			}
		}
	}

	float QuadLerp (float a1, float a2, float t) {
		return Mathf.Sqrt ((a2 * a2 * t) + (a1 * a1 * (1.0f - t)));
	}
}