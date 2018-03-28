using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

    public Animator anim;

    void Start ()
    {
		
	}
	

	void Update ()
    {
		
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
