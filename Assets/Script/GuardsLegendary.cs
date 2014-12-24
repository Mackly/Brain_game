using UnityEngine;
using System.Collections;

public class GuardsLegendary : MonoBehaviour {
    public Color green;
    public Color red;
    private Light m_Light;

    public Patrol cs;

    bool ok = false;

	// Use this for initialization
	void Start () {
        m_Light = GetComponent<Light>();
        m_Light.color = green;
	}
	
	// Update is called once per frame
	void Update () {
	}


/***************BESOIN D'UN RIGIBODY POUR CES FONTIONS ULTRA IMPORTANT !!!************************/

    void OnTriggerEnter(Collider obj)
    {
        if ((obj.gameObject.tag == "Player") && !ok)
        {
            m_Light.color = red;
            ok = true;
            Application.LoadLevel(1);
        }
    }
}
