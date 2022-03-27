using UnityEngine;
using System.Collections;

public class CollisionExit : MonoBehaviour {

	public GameObject ToActive ; 

	void OnTriggerExit(Collider targ ){
		Destroy (this.gameObject); 
		ToActive.SetActive(true); 
	}
}
