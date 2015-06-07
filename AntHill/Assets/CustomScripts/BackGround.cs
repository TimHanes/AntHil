using UnityEngine;
using System.Collections;

public class BackGround : MonoBehaviour {

	public GameObject RandomObject;
	public GameObject parts;
	public float x;
	public float y;
	public static float SizeY = 3.84F;



	void Update () { 
	
		RandomObject.transform.Translate(new Vector2 (0, 0.03F));
		                                 }

	void OnBecameInvisible()
	{
		gameObject.transform.localPosition = new Vector2
			(gameObject.transform.localPosition.x,
			 gameObject.transform.localPosition.y+(SizeY*4));
		RandomObject.transform.localPosition = new Vector2(
			(Random.value*2*x)-x, (y)); 

	}

}
