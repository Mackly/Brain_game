using UnityEngine;
using System.Collections;

public class MenuItem : MonoBehaviour {

    private MenuBase m_MainMenu;

	// Use this for initialization
	void Start () 
    {
        m_MainMenu = GetComponentInParent<MenuBase>();
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    void OnMouseEnter()
    {
        m_MainMenu.MouseOver(this.gameObject.name);
    }

    void OnMouseExit()
    {
        m_MainMenu.MouseOver("out");
    }

    void OnMouseUp()
    {
        m_MainMenu.ItemSelected(this);
    }
}
