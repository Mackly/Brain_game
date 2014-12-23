using UnityEngine;
using System.Collections;

public class levelS : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(4);
    }
}
