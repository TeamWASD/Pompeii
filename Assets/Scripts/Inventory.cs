using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

	private int rockCount = 0;
	public int RockCount
	{
		get { return rockCount; }
		set {
			if (rockCount < value) {
				for(; rockCount < value; ++rockCount) {
					GameObject.Find("Star" + (1 + rockCount)).renderer.enabled = true;
				}
			}
            else {
				for(; rockCount > value; --rockCount) {
					GameObject.Find("Star" + (rockCount)).renderer.enabled = false;
				}
			}
		}
	}
    
    private int brickCount = 0;
    public int BrickCount
    {
        get { return brickCount; }
        set {
            if (brickCount < value) {
                for (; brickCount < value; ++brickCount) {
                    GameObject.Find("Brick" + (1 + brickCount)).renderer.enabled = true;
                }
            }
            else {
                for (; brickCount > value; --brickCount) {
                    GameObject.Find("Brick" + (brickCount)).renderer.enabled = false;
                }
            }
        }
    }
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
