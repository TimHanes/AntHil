using UnityEngine;
using System.Collections;

public class AntControl : MonoBehaviour {
	public GameObject sphere;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (sphere.renderer.enabled&(sphere.transform.localScale.x < 1)){
			gameObject.transform.localPosition = new Vector2( sphere.transform.localPosition.x-1+sphere.transform.localScale.x,sphere.transform.localPosition.y-0.5F+(sphere.transform.localScale.x/2));
			gameObject.transform.rotation =
				Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x,-90, gameObject.transform.rotation.eulerAngles.z);
		}
		if (sphere.renderer.enabled&(sphere.transform.localScale.x >= 1))gameObject.transform.localPosition = sphere.transform.localPosition; 
		else gameObject.transform.Translate(new Vector3(0,0,0.05F));
	
	}
}
