using UnityEngine;
using System.Collections;

public class HeroControl : MonoBehaviour {
	public Hero mHero = null;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		// 鼠标左键 //
		if (Input.GetMouseButtonUp (0)) 
		{
			Vector3 pos = Vector3.zero;
			if ( Helper.GetRayPoint(ref pos) )
			{
				mHero.StartMove(pos);
			}
		}
	}
}
