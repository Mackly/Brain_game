using UnityEngine;
using System.Collections;

public class Bonus : MonoBehaviour {

    public float rotation;

	// Use this for initialization
	void Start () {
        rotation = 100;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.right* rotation * Time.deltaTime, Space.Self);
	}
}
