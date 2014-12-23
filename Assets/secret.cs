using UnityEngine;
using System.Collections;

public class secret : MonoBehaviour {

    public GUIText bonus;

	// Use this for initialization
	void Start () {
        bonus.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void On()
    {
        bonus.enabled = true;
    }

    public void Off()
    {
        bonus.enabled = false;
    }
}
