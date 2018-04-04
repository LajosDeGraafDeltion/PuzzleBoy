using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObjectNew : MonoBehaviour {

    public Transform transformCam;
    public LayerMask rayMask;
    public RaycastHit hit;

    private Transform currentTransform;
    private float length;

    public ObjectBounce oB;
	void Start ()
    {
		
	}
	

	void Update ()
    {
		if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(transformCam.position, transformCam.forward, out hit, 3f, rayMask))
            {
                if(hit.transform.tag == "Pickable")
                {
                    SetNewTransform(hit.transform);

                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            RemoveTransform();
        }

        if (currentTransform)
        {
            MoveTransformAround();
        }
	}

    public void SetNewTransform(Transform newTransform)
    {
        if (currentTransform)
        {
            return;
        }
            
        currentTransform = newTransform;

        length = Vector3.Distance(transformCam.position, newTransform.position);

        currentTransform.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void MoveTransformAround()
    {
        currentTransform.position = transformCam.position + transformCam.forward * length;
    }

    public void RemoveTransform()
    {
        if (!currentTransform)
        {
            return;
        }
        currentTransform.GetComponent<Rigidbody>().isKinematic = false;
        currentTransform = null;
        oB.touched = false;
        print("Untouched");
    }
}
