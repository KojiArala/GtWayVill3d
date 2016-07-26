using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIscriptingTest : MonoBehaviour {

	public Text accentText;
	public float fadeSpeed = 5f;
	public bool lookingAtWall;
	public GameObject accentCanvas;

	void Start ()
	{
		accentText = accentCanvas.GetComponentInChildren<Text> ();
		accentText.color = Color.clear;
	}


	void ColorChange()
	{
		if (lookingAtWall) 
		{
			accentText.color = Color.Lerp (accentText.color, Color.white, fadeSpeed = Time.deltaTime);
		}
		if (!lookingAtWall) 
		{
			accentText.color = Color.Lerp (accentText.color, Color.clear, fadeSpeed = Time.deltaTime);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		ColorChange ();	
		if (Input.GetKeyDown (KeyCode.T)) 
		    {
			lookingAtWall = true;
		}
		if (Input.GetKeyDown (KeyCode.Y)) 
		    {
			lookingAtWall = false;
		}

	}
}
