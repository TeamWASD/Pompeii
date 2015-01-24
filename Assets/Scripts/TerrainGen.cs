using UnityEngine;
using System;
using System.Collections;

public class TerrainGen : MonoBehaviour
{

	public int RockCount = 100;
	public Transform Rock;

	// Use this for initialization

	void Start () {
		for (int i=0; i < RockCount; ++i) {
			Vector3 pos = new Vector3(UnityEngine.Random.value * 100.0f - 50.0f, UnityEngine.Random.value * 100.0f - 50.0f, 0);
            if (Math.Sqrt((Math.Abs(pos.x) * Math.Abs(pos.x)) + (Math.Abs(pos.y) * Math.Abs(pos.y))) > 15)
            {
			    Instantiate(Rock, pos, Quaternion.identity);
            }
            else
            {
                --i;
            }
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
