using UnityEngine;
using System.Collections;

public class CameraTest : MonoBehaviour {
    public Transform obj;
	// Use this for initialization
	void Start () {
        transform.localEulerAngles = new Vector3(90,0,0);
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.position = (obj.position * 2f);
	}
}
