using UnityEngine;
using System.Collections;

public class LookDetection : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{

			if (hit.collider.name == "Door")
			{
				hit.collider.SendMessageUpwards ("animateDoor");
			}
			if (hit.collider.name == "AnimationTestCube")
			{
				hit.collider.SendMessageUpwards ("animateCube");
			}
			if (hit.collider.name == "AccentWall")
			{
				hit.collider.SendMessageUpwards ("colorChange");
			}

		}
	}
}
