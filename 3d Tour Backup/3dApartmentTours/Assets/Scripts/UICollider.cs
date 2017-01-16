using UnityEngine;
using System.Collections;

public class UICollider : MonoBehaviour {

	public string uiCommand;
	public string uiCommand2;

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			GameObject.Find("UIcontroller").GetComponent<UIscriptingTest>().MessageTest1();
		}
		
	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			GameObject.Find("UIcontroller").GetComponent<UIscriptingTest>().MessageTest2();
		}
		
	}
}
