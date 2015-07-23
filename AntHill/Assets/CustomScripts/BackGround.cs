using UnityEngine;
using System.Collections;
using UnityEngine.Sprites;

public class BackGround : MonoBehaviour {

	public GameObject RandomObject;


	void Update () { 


		RandomObject.transform.Translate(new Vector2 (0, 0.03F));
		                                 }

	void OnBecameInvisible()
	{
		float h = gameObject.renderer.bounds.size.y;
		float w = gameObject.renderer.bounds.size.x;
		float sizeRand = RandomObject.renderer.bounds.size.x;
		gameObject.transform.localPosition = new Vector2
			(gameObject.transform.localPosition.x,
			 gameObject.transform.localPosition.y+h*2);
		RandomObject.transform.localPosition = new Vector2(
			Random.value*(w-sizeRand)-w/2, 0); 

	}

}
