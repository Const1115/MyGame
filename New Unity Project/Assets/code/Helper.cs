using System.Collections;
using UnityEngine;
public class Helper
{
	static public bool GetRayPoint(ref Vector3 pos )
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit = new RaycastHit();
		if( Physics.Raycast(ray,out hit, 100))
		{
			pos = hit.point;
			return true;
		}

		return false;
	}


}