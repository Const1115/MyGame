using UnityEngine;
using System.Collections;

public class HeroMotion : MonoBehaviour 
{
	public Hero mHero = null;

	// 移动时间 //
	private float mTime = 0;
	private Vector3 mDir = Vector3.zero;
	private Animator mAnimator;

	public float MoveTime
	{
		get{ return mTime; }
		set{ mTime = value; }
	}

	public Vector3 MoveDir
	{
		get{ return mDir; }
		set{ mDir = value; }

	}

	// Use this for initialization
	void Start () 
	{
		mAnimator = gameObject.GetComponent<Animator>() as Animator;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (mTime > 0) 
		{
			mTime -= Time.deltaTime;
			mAnimator.SetFloat ("moveTime", mTime);
			gameObject.transform.position += mDir * mHero.GetSpeed () * Time.deltaTime;
		} else 
		{
			mAnimator.SetFloat ("moveTime", 0);
		}
	}
}
