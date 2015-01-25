using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public string SceneName = "MainScene";

	public void Play() {
		Application.LoadLevel(SceneName);
	}

	public void Quit() {
		Application.Quit ();
	}

}
