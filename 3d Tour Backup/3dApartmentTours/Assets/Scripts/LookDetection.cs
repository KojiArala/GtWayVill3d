using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LookDetection : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			if ((hit.collider.name == "Door") && (Input.GetKeyDown (KeyCode.F)))
			{
				hit.collider.SendMessageUpwards ("animateDoor");
			}
			if (hit.collider.name == "AccentWall")
			{
				if (Input.GetKeyDown (KeyCode.Alpha1))
				{
					hit.collider.SendMessageUpwards ("colorRed");					                              
				}
				if (Input.GetKeyDown (KeyCode.Alpha2))
				{
					hit.collider.SendMessageUpwards ("colorBlue");	
				}
				if (Input.GetKeyDown (KeyCode.Alpha3))
				{
					hit.collider.SendMessageUpwards ("colorWhite");
				}
			}
			if (hit.collider.name != "AccentWall")
			{
			}
		}
	}	
}
