using UnityEngine;
using System.Collections;

public class Hero : MonoBehaviour 
{
	private HeroControl mControl = null;
	private HeroMotion mMotion = null;
	private HeroProperty mProperty = null;
	private Animator mAnimator;
	// Use this for initialization
	void Start () 
	{
		mControl = gameObject.AddComponent<HeroControl> () as HeroControl;
		mControl.mHero = this;
		mMotion = gameObject.AddComponent<HeroMotion> () as HeroMotion;
		mMotion.mHero = this;
		mProperty = gameObject.AddComponent<HeroProperty> () as HeroProperty;


		mAnimator = gameObject.GetComponent<Animator>() as Animator;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void StartMove(Vector3 target)
	{
		// 计算时间 //
		float dis = Vector3.Distance (target, gameObject.transform.position);
		float time = dis / GetSpeed();
		mMotion.MoveTime = time;
		// 计算朝向 //
		Vector3 dir = target - gameObject.transform.position;
		dir.Normalize ();
		mMotion.MoveDir = dir;

		gameObject.transform.LookAt (target);
		
	}

	public float GetSpeed()
	{
		if (mProperty != null) 
		{
			return mProperty.mSpeed;
		}
		return 0;
	}

}
