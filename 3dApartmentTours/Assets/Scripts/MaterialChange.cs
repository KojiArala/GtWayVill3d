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
	
	void colorRed()
	{
		rend.sharedMaterial = material [0];
	}
	void colorBlue()
	{
		rend.sharedMaterial = material [1];
	}
	void colorWhite()
	{
		rend.sharedMaterial = material [2];
	}
}
