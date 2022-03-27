using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement ; 

public class SceneLoader : MonoBehaviour {

	public void Menu(){
		Application.LoadLevel ("Main2"); 
	}

	public void nextMenu(){
		Application.LoadLevel ("SecondScene"); 
	}
	public void nextMenuAlpha(){
		Application.LoadLevel ("SecondSceneAlphabet"); 
	}
	public void Exit(){
		Application.Quit(); 
	}
	public void Option(){
		Application.LoadLevel ("Option"); 
	}
}