using UnityEngine;
using System.Collections;

public class InOut : MonoBehaviour {

    private Menu menu;

	// Use this for initialization
	void Start () {
        menu = GetComponentInParent<Menu>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseEnter()
    {
        notify();
    }

    void OnMouseExit()
    {
        menu.receveNotify("out", this);
    }

    void notify()
    {
        menu.receveNotify(this.gameObject.name, this);
    }

    void OnMouseUp()
    {
        menu.receveNotify(this);
    }
}
