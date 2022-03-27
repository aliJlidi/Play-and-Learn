using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement ; 

public class GameManger : MonoBehaviour {

	public GameObject pauseMenu; 
	public GameObject pauseButton; 
	public GameObject LevelOver; 


	public void Pause(){


		Time.timeScale = 0; 
		pauseMenu.SetActive (true); 
		pauseButton.SetActive (false);

	}
	public void Play(){

		pauseMenu.SetActive (false); 
		Time.timeScale = 1; 
		pauseButton.SetActive (true); 


	}
	public void Reload(){
		pauseButton.SetActive (true);
		Time.timeScale = 1; 
		Application.LoadLevel(Application.loadedLevel);
		LevelOver.SetActive (false);
		pauseMenu.SetActive (false);
		onTriggerAction.y = 1;
		onTriggerAction.z = 0;
		onTriggerAction.w = 4;
		characterTrigger.WalkHealth = 4; 
		characterTrigger.increaseNum = 1; 


	}
	public void Menu(){
		Time.timeScale = 1; 
		onTriggerAction.y = 1;
		onTriggerAction.z = 0;
		onTriggerAction.w = 4;
		LevelOver.SetActive (false);
		Application.LoadLevel("Main1"); 
	}

}