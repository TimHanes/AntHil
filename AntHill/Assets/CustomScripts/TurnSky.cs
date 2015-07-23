using UnityEngine;
using System.Collections;

public class TurnSky : MonoBehaviour {
	public GameObject relatedObject;
	public float ratio;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.localPosition = relatedObject.transform.localPosition;
		gameObject.transform.rotation =
			Quaternion.Euler( relatedObject.transform.localPosition.y,gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z );
	}
}
