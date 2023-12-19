using System.Collections;
using System.Collections.Generics;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Test : MonoBehavior{
	
	Rigidbody rb;
	float xInput, zInput;
	
	public float speed;

	void Start(){
		rb=GetComponent<RigidBody>();
	}
	void Update(){
		if(Input.GetKeyDown(KeyCode.R))
			
	}
	xInput = Input.GetAxis("Horizontal");
	zInput = InputGetAxis("Vertical");
	
	rb.AddForce(xInput * speed, 0, zInput * speed);
}