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

	public float Dim = 0.5f;
	private float _cooldown = 0.0f;
	public float Cooldown
	{
		get { return _cooldown; }
		set {
			if (value <= 0.0f) {
				_cooldown = 0.0f;
				Color c = ((SpriteRenderer) renderer).color;
				c.a = 1.0f;
				((SpriteRenderer) renderer).color = c;
			} else {
				_cooldown = value;
				Color c = ((SpriteRenderer) renderer).color;
				c.a = Dim;
				((SpriteRenderer) renderer).color = c;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (_cooldown > 0.0f) {
			_cooldown -= Time.deltaTime;
			if (_cooldown <= 0.0f) {
				_cooldown = 0.0f;
				Color c = ((SpriteRenderer) renderer).color;
				c.a = 1.0f;
				((SpriteRenderer) renderer).color = c;
			}
		}
	}


}
