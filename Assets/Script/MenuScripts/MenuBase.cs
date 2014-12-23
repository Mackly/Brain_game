using UnityEngine;
using System.Collections;

// Classe menu de base
public class MenuBase : MonoBehaviour
{
    protected Camera m_Camera;

    // Use this for initialization
    void Start()
    {
        Init();
    }
    // Needs to be called in the derived class by base.Init() if overriden
    public virtual void Init()
    {
        m_Camera = FindObjectOfType<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
    }

    // Function to override
    public virtual void MouseOver(string name)
    {
    }

    // Function to override
    public virtual void ItemSelected(MenuItem item)
    {
    }

}
