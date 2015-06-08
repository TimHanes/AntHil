using UnityEngine;
using System.Collections;


public class AirControl : MonoBehaviour {
	public float Speed;
	public float RotationSpeedRightLeft;
	public float RotationSpeedUpDown;
	public float LimitLeft;
	public float LimitRight;
	float lim;
	float speed;
	public GameObject backGround1;
	public GameObject backGround2;
	public float delta = 0.01F;


	public float TimerBurst = 5;
	float _timerBurst;
	// Use this for initialization

	void Start (){
		_timerBurst = TimerBurst; 
		gameObject.transform.localScale = new Vector3(0, 0, 0);
	} 
	void Update () 
	{ 
		if (gameObject.renderer.enabled)
		{
			if (gameObject.transform.localScale.x >= 1)
				{
					if (((transform.localPosition.x > LimitRight)& (Input.GetAxis ("Horizontal")>0))|			
		    			((transform.localPosition.x < LimitLeft)& (Input.GetAxis ("Horizontal")<0)))
						lim = 0; 
						else lim =  (Input.GetAxis ("Horizontal")*RotationSpeedRightLeft);
		
						speed = (Input.GetAxis ("Vertical") * RotationSpeedRightLeft)+Speed;
						transform.Translate (new Vector2 (lim, speed));					
			} else {gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x+delta,
				                                                     gameObject.transform.localScale.y+delta,
				                                                     gameObject.transform.localScale.z+delta); }
		} else 
						{ 
							_timerBurst -= Time.deltaTime;  
							if (_timerBurst <= 0.0f) 
								{gameObject.renderer.enabled = true; _timerBurst = TimerBurst; Burst(); }
			
						}

	}
	void Burst(){
		
		gameObject.transform.localScale = new Vector3(0, 0, 0);
		gameObject.renderer.enabled = true;
		backGround1.transform.localPosition = new Vector2(0, -BackGround.SizeY);
		backGround2.transform.localPosition = new Vector2(0, BackGround.SizeY);
		gameObject.transform.localPosition = new Vector2(0, 0);
		--Result.Life;
		
		
	}
}
