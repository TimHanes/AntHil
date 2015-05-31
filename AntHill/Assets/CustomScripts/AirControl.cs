using UnityEngine;
using System.Collections;

public class AirControl : MonoBehaviour {
	public float Speed;
	public float RotationSpeedRightLeft;
	public float RotationSpeedUpDown;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, Speed, 0));
		transform.Translate (new Vector3 (0, Input.GetAxis ("Vertical") * RotationSpeedRightLeft, 0));
		transform.Translate (new Vector3 (Input.GetAxis ("Horizontal") * RotationSpeedRightLeft, 0, 0));
	}
}
