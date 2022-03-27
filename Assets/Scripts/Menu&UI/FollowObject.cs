using UnityEngine;
using System.Collections;

public class FollowObject : MonoBehaviour {
	public Transform targetObject ; 
	public float distanceFromTarget ; 
	public float setHieght ; 
	public float xAngle ; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var wantedHieght = targetObject.position.y + setHieght; 
		// follow the target 
		transform.rotation = Quaternion.Euler(xAngle , targetObject.eulerAngles.y +90, 0 ) ; 
		transform.position = targetObject.position - transform.forward * distanceFromTarget; 
		transform.position = new Vector3 (transform.position.x , wantedHieght, transform.position.z); 
	
	}
}
