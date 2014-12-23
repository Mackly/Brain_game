using UnityEngine;
using System.Collections;

public class WallPlacement : MonoBehaviour {

    public Transform planet;

	// Use this for initialization
	void Start () {

        Vector3 gravityDown = (-transform.position + planet.transform.position).normalized;
        Vector3 left = Vector3.Cross(transform.up, new Vector3(1,1,1));
        Debug.Log(left);
        transform.rotation = Quaternion.LookRotation(gravityDown);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
