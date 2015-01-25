using UnityEngine;
using System.Collections;

public class RemotePause : MonoBehaviour {

	public void TogglePause() {
		GameObject.FindWithTag ("Player").GetComponent<Pause> ().TogglePause ();
	}
	
	public void PauseGame() {
		GameObject.FindWithTag ("Player").GetComponent<Pause> ().PauseGame ();
	}
	
	public void UnPauseGame() {
		GameObject.FindWithTag ("Player").GetComponent<Pause> ().UnPauseGame ();
	}
}
