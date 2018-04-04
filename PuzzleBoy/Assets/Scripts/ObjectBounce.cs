using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBounce : MonoBehaviour {

    public Rigidbody rbBox;
    public bool beingCarried;
    public bool touched;

    public PickableObjectNew poN;

	void Start ()
    {
        rbBox = GetComponent<Rigidbody>();
	}
	

	void Update ()
    {
        if(rbBox.isKinematic == true && touched == true)
        {
            poN.RemoveTransform();
            touched = false;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (rbBox.isKinematic == true)
        {
            touched = true;
            print("Touched");
        }
    }


}
