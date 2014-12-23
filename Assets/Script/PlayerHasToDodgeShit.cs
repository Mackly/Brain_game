using UnityEngine;
using System.Collections;

public class PlayerHasToDodgeShit : MonoBehaviour {

    private float speed = 10f;
    private Vector3 spwan;

    Vector3 movdir;
    Vector3 rotate;

	// Use this for initialization
	void Start () {
        spwan = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        movdir = new Vector3(0, 0, Input.GetAxisRaw("Vertical")).normalized;
        rotate = new Vector3(0, Input.GetAxisRaw("Horizontal") * 2, 0);

	}

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + speed * transform.TransformDirection(movdir) * Time.deltaTime);
        transform.localEulerAngles += rotate;
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Ennemy")
        {
            transform.position = spwan;
        }
    }
    
}
