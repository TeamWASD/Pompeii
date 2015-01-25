using UnityEngine;
using System;
using System.Collections;

public class TerrainGen : MonoBehaviour
{

	public int RockCount = 100;
	public float Radius = 15.0f;
	public Transform Rock;

	// Use this for initialization

	void Start () {
		for (int i=0; i < RockCount; ++i) {
			Vector3 pos;
			do {
				pos = new Vector3(UnityEngine.Random.value * 100.0f - 50.0f, UnityEngine.Random.value * 100.0f - 50.0f, 0);   
			} while (Mathf.Sqrt((Mathf.Abs(pos.x) * Mathf.Abs(pos.x)) + (Mathf.Abs(pos.y) * Mathf.Abs(pos.y))) < Radius);
			Instantiate(Rock, pos, Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
