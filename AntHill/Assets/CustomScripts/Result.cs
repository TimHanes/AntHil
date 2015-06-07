using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour {
	public Text txt;
	public static int Life = 5;
	public int record = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Life == 0) {record = 0; Life = 5;}
		int x;
		x = (int) gameObject.transform.position.y;
		if (x>record) record = x;
		txt.text ="Hight = "+ x + "  Life = " + Life + "   Record = "+record;
	}
}
