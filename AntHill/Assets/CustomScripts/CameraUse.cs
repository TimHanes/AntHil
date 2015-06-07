using UnityEngine;
using System.Collections;

public class CameraUse : MonoBehaviour {
	public GameObject cam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 
			cam.transform.localPosition = new Vector3
				(cam.transform.localPosition.x, 
			 gameObject.transform.localPosition.y+cam.camera.orthographicSize/2, 
			 cam.transform.localPosition.z) ;
	

	}
}
