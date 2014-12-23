using UnityEngine;
using System.Collections;

public class Grav : MonoBehaviour {
    public Gravity grav;
    private Transform myTransform;

	// Use this for initialization
	void Start () {
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        rigidbody.useGravity = false;
        myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        grav.Attract(myTransform);
	}
}
