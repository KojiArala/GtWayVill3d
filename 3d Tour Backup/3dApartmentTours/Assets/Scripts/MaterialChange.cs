using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MaterialChange : MonoBehaviour {

	public Material[] material;
	Renderer rend;
	public Text accentText;
	public GameObject roomCanvas;
	public int currentColor = 0;


	// Use this for initialization
	void Start () 
	{
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [0];
		accentText = roomCanvas.GetComponentInChildren<Text> ();
	}
	public void changeColor()
	{
		if (currentColor <= 5) 
		{
			currentColor += 1;
			print ("currentColor is less than 5!");
		}
		if (currentColor == 6) 
		{
			currentColor = 0;
			print ("currentColor is reset to 0!");
		}
	}	
	void Update()
	{
		if (currentColor == 0) 
		{
			rend.sharedMaterial = material [0];
			accentText.text = "hange Accent Color Basil";
		}
		if (currentColor == 1) 
		{
			rend.sharedMaterial = material [1];
			accentText.text = "hange Accent Color Mediterranean";
		}
		if (currentColor == 2) 
		{
			rend.sharedMaterial = material [2];
			accentText.text = "hange Accent Color Burnished Brandy";
		}
		if (currentColor == 3) 
		{
			rend.sharedMaterial = material [3];
			accentText.text = "hange Accent Color Artisan Tan";
		}
		if (currentColor == 4) 
		{
			rend.sharedMaterial = material [4];
			accentText.text = "hange Accent Color Breezy";
		}
		if (currentColor == 5) 
		{
			rend.sharedMaterial = material [5];
			accentText.text = "hange Accent Color Rustic Red";

		}
	}
}
