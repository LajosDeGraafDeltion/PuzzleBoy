using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

    public Animator anim;
    public GameObject pressurePlate;
    public GameObject targetDoor;
    public DoorAnimScr doorAnimation;

    void Start ()
    {
		
	}
	

	void Update ()
    {
        if (anim.GetBool("Pressed"))
        {
            doorAnimation.OpenDoor();
        }
	}

    public void OnTriggerEnter(Collider other)
    {
        anim.SetBool("Pressed", true);
    }

    public void OnTriggerExit(Collider other)
    {
        anim.SetBool("Pressed", false);
    }
}
