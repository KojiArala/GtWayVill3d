using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIscriptingTest : MonoBehaviour {

	public Text accentText;
	public Image wButton;
	public Image aButton;
	public Image sButton;
	public Image dButton;
	public Image cButton;
	public Sprite wupSprite;
	public Sprite wdownSprite;
	public Sprite aupSprite;
	public Sprite adownSprite;
	public Sprite supSprite;
	public Sprite sdownSprite;
	public Sprite dupSprite;
	public Sprite ddownSprite;
	public Sprite cupSprite;
	public Sprite cdownSprite;
	public float fadeSpeed = 5f;
	public bool inLivingRoom;
	public GameObject roomCanvas;

	void Awake ()
	{
		accentText = roomCanvas.GetComponentInChildren<Text> ();
		wButton = roomCanvas.GetComponentInChildren<Image> ();
		accentText.color = Color.clear;
		wButton.sprite = wupSprite;
		aButton.sprite = aupSprite;
		sButton.sprite = supSprite;
		dButton.sprite = dupSprite;

	}


	void Update ()
	{
		ShowAccentInfo ();
		UIhighlights ();
	}


	void ShowAccentInfo()
	{
		if (inLivingRoom) 
		{
			accentText.color = Color.Lerp (accentText.color, Color.white, fadeSpeed = Time.deltaTime);
		}
		if (!inLivingRoom) 
		{
			accentText.color = Color.Lerp (accentText.color, Color.clear, fadeSpeed = Time.deltaTime);
		}
	}

	void UIhighlights()
	{
		if (Input.GetKeyDown (KeyCode.W)) 
		{
			wButton.sprite = wdownSprite;
		}
		if (Input.GetKeyUp (KeyCode.W)) 
		{
			wButton.sprite = wupSprite;
		}
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			aButton.sprite = adownSprite;
		}
		if (Input.GetKeyUp (KeyCode.A)) 
		{
			aButton.sprite = aupSprite;
		}
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			sButton.sprite = sdownSprite;
		}
		if (Input.GetKeyUp (KeyCode.S)) 
		{
			sButton.sprite = supSprite;
		}
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			dButton.sprite = ddownSprite;
		}
		if (Input.GetKeyUp (KeyCode.D)) 
		{
			dButton.sprite = dupSprite;
		}
	}

	public void MessageTest1()
	{
		inLivingRoom == true;
	}
	public void MessageTest2()
	{
		inLivingRoom == false;
	}

}