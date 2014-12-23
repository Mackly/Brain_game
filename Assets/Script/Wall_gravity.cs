using UnityEngine;
using System.Collections;

public class Wall_gravity : MonoBehaviour {

    public Gravity grav;
    private Transform myTransform;

    // Use this for initialization
    void Start()
    {
        grav = GameObject.Find("Cell").GetComponent<Gravity>();
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        rigidbody.useGravity = false;
        myTransform = transform ;
    }

    // Update is called once per frame
    void Update()
    {
        grav.Attract(myTransform);
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Cell")
        {
            rigidbody.isKinematic = true;
        }
    }
}
