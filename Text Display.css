using System.Collections;
using System.Collections.Generics;

public class Test : MonoBehavior{
	
	Rigidbody rb;
	public GameObject winText; // drag and drop
	void Start(){
		rb=GetComponent<RigidBody>();
	}
	void Update(){

	}
	
	private void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag == "Enemy"){
			//Destroy(gameObject);
			Destroy(collision.gameObject);
			winText.SetActive(true);
		}
	}
}