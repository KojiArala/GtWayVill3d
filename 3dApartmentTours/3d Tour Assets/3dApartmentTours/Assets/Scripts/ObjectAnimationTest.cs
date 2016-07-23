using UnityEngine;
using System.Collections;

public class ObjectAnimationTest : MonoBehaviour {
	public Animation anim;

	void animateCube()
	{
		if (Input.GetKeyDown (KeyCode.F)) {
			animation.Play ("CubeMoveTest");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
