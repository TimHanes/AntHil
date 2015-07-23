using UnityEngine;
using System.Collections;

public class DriveSpeed : MonoBehaviour {
	public GameObject relatedObject;
	public float ratio;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.localPosition = new Vector2 
			(0,
			 ((relatedObject.transform.localPosition.y-gameObject.transform.localPosition.y*ratio)/ratio)
			 +gameObject.transform.localPosition.y);
	
	}
}
