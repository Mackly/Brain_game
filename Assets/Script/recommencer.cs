using UnityEngine;
using System.Collections;

public class recommencer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

        void OnMouseDown()
    {
        Application.LoadLevel("Prototype");
    }
}
