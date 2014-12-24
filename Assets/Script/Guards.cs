using UnityEngine;
using System.Collections;

public class Guards : MonoBehaviour {
    public Color green;
    public Color red;
    public Camera cam;
    private Light m_Light;

    public Patrol cs;

    float timer = 0;
    bool ok = false;

	// Use this for initialization
	void Start () {
        m_Light = GetComponent<Light>();
        m_Light.color = green;
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
            m_Light.color = red;
            cam.enabled = true;
            ok = true;
            timer = 5;
            cs.detected();
        }
    }
}
