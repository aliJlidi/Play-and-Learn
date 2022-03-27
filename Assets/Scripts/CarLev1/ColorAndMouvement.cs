using UnityEngine;
using System.Collections;

public class ColorAndMouvement : MonoBehaviour {

	public Color col1;
	public Color col2; 
	public float rotSpeed = 80f ; 

	// Use this for initialization
	void Start () {

		StartCoroutine (ChangeCol ());
	}

	IEnumerator ChangeCol(){
		while (true) {
			GetComponent<Renderer> ().material.SetColor ("_Color", col1); 
			yield return new WaitForSeconds (.8f); 
			GetComponent<Renderer> ().material.SetColor ("_Color", col2); 
			yield return new WaitForSeconds (.8f); 
		}
	}
	void Update(){

		transform.Rotate (0, rotSpeed * Time.deltaTime, 0, Space.World);
	}

}