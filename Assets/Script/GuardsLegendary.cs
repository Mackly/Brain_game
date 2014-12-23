using UnityEngine;
using System.Collections;

public class GuardsLegendary : MonoBehaviour {
    public Color green;
    public Color red;
    Light light;

    public Patrol cs;

    float timer = 0;
    bool ok = false;
    float speed = 5;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        light.color = green;
	}
	
	// Update is called once per frame
	void Update () {
	}


/***************BESOIN D'UN RIGIBODY POUR CES FONTIONS ULTRA IMPORTANT !!!************************/

    void OnTriggerEnter(Collider obj)
    {
        if ((obj.gameObject.tag == "Player") && !ok)
        {
            light.color = red;
            ok = true;
            Application.LoadLevel(1);
        }
    }
}
