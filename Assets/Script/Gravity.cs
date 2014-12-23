using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gravity : MonoBehaviour {
    //List<Rigidbody> listGravite;
    float gravity = -12f;

	// Use this for initialization
	/*void Start () {
	    //listGravite = new List<Rigidbody>();
        
	}*/
	
	// Update is called once per frame
	/*void Update () {
        for (int i = 0; i < listGravite.Count; i++)
        {
            listGravite[i].AddForce(gravity*listGravite[i].mass*(this.transform.position - listGravite[i].transform.position * Time.deltaTime));
        }
	}

    void OnTriggerEnter(Collider obj)
    {
        listGravite.Add(obj.GetComponent<Rigidbody>());
    }

    void OnTriggerExit(Collider obj)
    {
        listGravite.Remove(obj.GetComponent<Rigidbody>());
    }*/


    public void Attract(Transform obj)
    {
        Vector3 gravityUp = (obj.position - transform.position).normalized; //Vecteur representant la gravité
        Vector3 objVectorUp = obj.up; //Position du haut de l'objet

        obj.rigidbody.AddForce(gravityUp * gravity); //On calcule la gravité

        Quaternion transformRotation = Quaternion.FromToRotation(objVectorUp, gravityUp) * obj.rotation; //Donne le degres manquant entre la gravité et l'objet
        obj.rotation = Quaternion.Slerp(obj.rotation, transformRotation,50f*Time.deltaTime); //On comble le manque a vitesse de 50

    }
}
