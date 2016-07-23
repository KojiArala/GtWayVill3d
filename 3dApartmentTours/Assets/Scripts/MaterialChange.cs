using UnityEngine;
using System.Collections;

public class MaterialChange : MonoBehaviour {

	public Material[] material;
	Renderer rend;


	// Use this for initialization
	void Start () 
	{
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [0];
	}
	
	void colorChange()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1))
		{
			print ("Pressed 1");
			rend.sharedMaterial = material [0];
		}
		if (Input.GetKeyDown (KeyCode.Alpha2))
		    {
			print ("Pressed 2");
			rend.sharedMaterial = material [1];
		}
		if (Input.GetKeyDown (KeyCode.Alpha3))
		    {
			print ("Pressed 3");
			rend.sharedMaterial = material [2];
		}
	}
}
