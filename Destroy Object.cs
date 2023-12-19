using System.Collections;
using System.Collections.Generics;

public class Test : MonoBehavior{

	void Start(){
		//Destroy(gameObject,5f); //destroy after 5 sec
	}
	void Update(){
		if(input.GetKeyDown(KeyCode.Space))
			Destroy(gameObject); // keyboard input
	}

	private void OnMouseClick(){
		Destroy(gameObject); // mouse input
	}
}