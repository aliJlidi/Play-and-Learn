using UnityEngine;
using System.Collections;

public class characterTrigger : MonoBehaviour {
	public static int WalkHealth = 4 ;
	public static int increaseNum = 1 ; 
	public static float increaseScore = 0 ; 
	public GameObject youLose ; 
	public GameObject pauseButton ; 
	public GameObject winPanel; 


	// Use this for initialization
	void OnTriggerEnter ( Collider col ) {
		if (col.tag == "Trap") {
			WalkHealth -= 1; 
			if (WalkHealth == 3) {
				Destroy (GameObject.FindWithTag("F3"));
			}
			if (WalkHealth == 2) {
				Destroy (GameObject.FindWithTag("F2"));
			}
			if (WalkHealth == 1) {
				Destroy (GameObject.FindWithTag("F1"));
			}
			if (WalkHealth == 0) {
				youLose.SetActive(true);
				Time.timeScale = 0; 
				pauseButton.SetActive (false); 
			}
		
		}
		if (col.tag == "T") {
			increaseNum += 1; 
			increaseScore += .2f;
		}
		if (col.tag == "Win") {
			winPanel.SetActive(true);  
			Time.timeScale = 0; 
			pauseButton.SetActive (false); 
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
