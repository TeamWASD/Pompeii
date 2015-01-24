using UnityEngine;
using System.Collections;

public class TerrainGen : MonoBehaviour
{

	public int RockCount = 100;
	public Transform Rock;

	// Use this for initialization

	void Start () {
		for (int i=0; i < RockCount; ++i) {
			Vector3 pos = new Vector3(Random.Range(-50,50), Random.Range (-50,50), 0);
			Instantiate(Rock, pos, Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
