using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour 
{
	public GameObject mTarget;
	public float xOffet = 5;
	public float yOffet = 5;
	public float zOffet = 5;
	// Use this for initialization
	void Start () 
	{
		if (mTarget == null) 
		{
			mTarget = GameObject.Find("Hero") as GameObject;		
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void LateUpdate ()
	{
		if (mTarget != null) 
		{
			Vector3 pos = mTarget.transform.position;
			pos.x += xOffet;
			pos.y += yOffet;
			pos.z += zOffet;
			this.transform.position = pos;
			transform.LookAt(mTarget.transform);
		}
	}
}
