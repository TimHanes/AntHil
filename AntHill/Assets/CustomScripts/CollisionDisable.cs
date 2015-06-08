using UnityEngine;
using System.Collections;
using System.Timers;

public class CollisionDisable : MonoBehaviour {

	public GameObject sphere;

	public GameObject parts;
	GameObject[] part; 


	void Start(){
		 
	}


	void Update () {



	}



	void OnTriggerEnter2D()
	{ 
		part = new GameObject[6]{

			(GameObject)Instantiate(parts,sphere.transform.position,sphere.transform.rotation),
			(GameObject)Instantiate(parts,sphere.transform.position,sphere.transform.rotation),
			(GameObject)Instantiate(parts,sphere.transform.position,sphere.transform.rotation),
			(GameObject)Instantiate(parts,sphere.transform.position,sphere.transform.rotation),
			(GameObject)Instantiate(parts,sphere.transform.position,sphere.transform.rotation),
			(GameObject)Instantiate(parts,sphere.transform.position,sphere.transform.rotation)};

		sphere.renderer.enabled = false;
		

	
}


}

	

