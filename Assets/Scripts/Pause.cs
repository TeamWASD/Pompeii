using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	private float _timeScale = 1.0f;
	private bool isPaused = false;
	private GameObject pause;

	// Use this for initialization
	void Start () {
		pause = GameObject.FindWithTag ("Pause");
		pause.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape")) {
			TogglePause();
		}
	}

	public void TogglePause() {
		if (isPaused)
			UnPauseGame ();
		else
			PauseGame ();
	}

	public void PauseGame() {
		_timeScale = Time.timeScale;
		Time.timeScale = 0.0f;
		pause.SetActive (true);
		isPaused = true;
	}

	public void UnPauseGame() {
		Time.timeScale = _timeScale;
		pause.SetActive (false);
		isPaused = false;
	}

}
