using UnityEngine;
using System.Collections;

public class TimeEneble : MonoBehaviour {
	float _x;
	float _y;

	// Use this for initialization
	void Start () {
		_x = (Random.value-0.5F)/4;
		_y = (Random.value - 0.5F)/4;
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(new Vector2(_x, _y));
		Destroy(gameObject, 5);
	}
}
