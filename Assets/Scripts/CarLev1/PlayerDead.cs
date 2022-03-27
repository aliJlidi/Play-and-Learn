using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {

	public GameObject LevelOver ; 
	public GameObject pauseButton;

	void OnTriggerEnter(Collider col ) {
		if (col.tag == "Dd") {
			Time.timeScale = 0; 
			LevelOver.SetActive (true);
			pauseButton.SetActive (false);

		}
	}
}
