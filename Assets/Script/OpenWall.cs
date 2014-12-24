using UnityEngine;
using System.Collections;

public class OpenWall : MonoBehaviour {

    public Rigidbody_test Player;

	void Start () {
	
	}
	
	void Update () {
        if (Player.getPower())
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
            Color color = renderer.material.color;
            color.a = 0.5f;
            renderer.material.color = color;
        }
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Color color = renderer.material.color;
            color.a = 1.0f;
            renderer.material.color = color;
        }
    }
}
