using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHolder : MonoBehaviour {

    public int pickAmount;

    public List<GameObject> pickedObj = new List<GameObject>();

    void Start ()
    {
		
	}

	void Update ()
    {

        for (int i = 0; i < pickAmount; i++)
        {
            GetComponent<Rigidbody>().isKinematic = false;
        }

    }
}
