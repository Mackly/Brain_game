using UnityEngine;
using System.Collections;

public class Guards : MonoBehaviour {
    public Color green;
    public Color red;
    public Camera cam;
    Light light;

    public Patrol cs;

    float timer = 0;
    bool ok = false;
    float speed = 5;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        light.color = green;
        cam.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer < 0 && ok)
        {
            cam.enabled = false;
        }
	}


/***************BESOIN D'UN RIGIBODY POUR CES FONTIONS ULTRA IMPORTANT !!!************************/

    void OnTriggerEnter(Collider obj)
    {
        if ((obj.gameObject.tag == "Player") && !ok)
        {
            light.color = red;
            cam.enabled = true;
            ok = true;
            timer = 5;
            cs.detected();
        }
    }
}
