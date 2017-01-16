using UnityEngine;
using System.Collections;

public class NewAnimatedDoor : MonoBehaviour 
{
	
	Animator anim;
	public int openHash = Animator.StringToHash ("Door Open");
	public int closeHash = Animator.StringToHash ("DoorClose");
	public bool doorOpen = false;
		
	
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	
	void animateDoor()
	{
		if (anim.GetCurrentAnimatorStateInfo(0).IsName("Door Idle")) 
		{
			anim.SetTrigger (openHash);
		}
		if (anim.GetCurrentAnimatorStateInfo(0).IsName("DoorIdleOpen"))
		{
			anim.SetTrigger (closeHash);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
}
