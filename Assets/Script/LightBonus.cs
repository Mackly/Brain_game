using UnityEngine;
using System.Collections;

public class LightBonus : MonoBehaviour {
    public float rotation;

	// Use this for initialization
	void Start () {
        rotation = 100;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.up * Time.deltaTime * rotation);
	}
}
