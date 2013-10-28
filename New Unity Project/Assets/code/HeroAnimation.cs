using UnityEngine;
using System.Collections;

public class HeroAnimation : MonoBehaviour 
{
	public Hero mHero = null;
	public enum EState
	{
		IDLE,
		WALK,
	};

	private EState mCurState = EState.IDLE;
	private Animator mAnimator = null;

	//public  EState State
	//{
//		get{ return mCurState; }
//		set
//		{
//			if ( mAnimator != null )
//			{
//
//				mAnimator.SetFloat("moveTime", );
//			}
//		}
	//}

	// Use this for initialization
	void Start () {
		mAnimator = gameObject.GetComponent<Animator>() as Animator;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
