using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CyaWall : MonoBehaviour {

    float timer;
    bool activeTimer;
    Stack<Collider> bibi = new Stack<Collider>();
    public float a = 0;

	// Use this for initialization
	void Start () {
        timer = 0.5f;
        activeTimer = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (activeTimer)
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                while(bibi.Count != 0) //Pop pas tous
                {
                    Collider obj = bibi.Pop();
                    obj.renderer.enabled = true;
                    obj.collider.enabled = true;
                    activeTimer = false;
                    a--;
                }
            }
        }
	
	}

    void OnTriggerEnter(Collider obj)
    {

        if (obj.gameObject.tag == "Mur")
        {
            obj.renderer.enabled = false;
            obj.collider.enabled = false;
            activeTimer = true;
            bibi.Push(obj);
            timer = 4f;
            a = bibi.Count;
        }
    }
}
