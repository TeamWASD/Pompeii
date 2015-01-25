using UnityEngine;
using System.Collections;

public class NewGameButton : MonoBehaviour {

	public void Play() {
		Application.LoadLevel("MainScene");
	}

}
