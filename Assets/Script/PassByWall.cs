using UnityEngine;
using System.Collections;

public class PassByWall : MonoBehaviour {

    public Rigidbody_test player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (player.getPower())
        {
            collider.isTrigger = true;
        }

        else
        {
            collider.isTrigger = false;
        }
	}


  /*****POUR UTILISER ALPHA,IL FAUT AVOIR LE BON SHADER SOIT TRANSPARENT->DIFFUSE*******/

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Renderer T = GetComponentInChildren<Renderer>();
            Color color = T.material.color;
            color.a = 0.5f;
            T.material.color = color;
        }
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Renderer T = GetComponentInChildren<Renderer>();
            Color color = T.material.color;
            color.a = 1f;
            T.material.color = color;
        }
    }
}
