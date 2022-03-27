using UnityEngine;
using System.Collections;
using UnityEngine.UI ; 

public class CaseNum : MonoBehaviour {

	Text oper ; 
	bool getPass ;  
	int x ; 

	// Use this for initialization
	void Start () {




	}



	// Update is called once per frame
	void FixedUpdate () {
		oper = GetComponent<Text> ();
		getPass = fadeAndChange.pass; 
		x = characterTrigger.increaseNum ; 

		if (getPass){

			switch (x) {
			case 1: 
				oper.text = " 0 "; 
				break; 
			case 2: 
				oper.text =  " 1"; 
				break; 
			case 3: 
				oper.text = " 2 "; 
				break; 
			case 4: 
				oper.text = " 3 "; 
				break; 
			case 5: 
				oper.text = " 4 "; 
				break; 
			case 6: 
				oper.text = " 5 "; 
				break; 
			case 7: 
				oper.text = " 6 "; 
				break; 
			case 8: 
				oper.text = " 7 "; 
				break; 
			case 9: 
				oper.text = " 8 "; 
				break; 
			case 10: 
				oper.text = " 9 "; 
				break; 

			}


		}

	}
}

