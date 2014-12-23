using UnityEngine;
using System.Collections;

public class InOut2 : MonoBehaviour {

    private Menu2 menu;

	// Use this for initialization
	void Start () {
        menu = GetComponentInParent<Menu2>();
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
