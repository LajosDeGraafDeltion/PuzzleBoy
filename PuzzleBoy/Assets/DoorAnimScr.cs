using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimScr : MonoBehaviour {

    public Animator doorAnim;

    void Start ()
    {
		
	}
	

	void Update ()
    {
		
	}

    public void OpenDoor()
    {
        doorAnim.SetBool("Open", true);
    }
}
