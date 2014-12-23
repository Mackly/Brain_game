using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Create_maze : MonoBehaviour {
    
    public Transform prefab;
    float size;
    private const float DEGRES = 0;
    public float phi = 0;
    public float theta = 0;

    private KeyValuePair<float, float> pair;
    private List<KeyValuePair<float, float>> listeDePoints;
	
	void Instanciate(float degres, float phi, float theta)
    {
        //Positionnons l'objet
        size = (transform.localScale.y / (1.95f));

        float distance = Mathf.Cos(toRad(degres))* size + Mathf.Sin(toRad(degres))*size;
        phi = toRad(phi);
        theta = toRad(theta);

        float x = distance * Mathf.Sin(phi) * Mathf.Cos(theta);
        float y = distance * Mathf.Sin(phi) * Mathf.Sin(theta);
        float z = distance * Mathf.Cos(phi);

        Object objTmp = Instantiate(prefab, new Vector3(x,y,z), Quaternion.identity);
        Transform obj = (Transform)objTmp;

        //Essayons de lui donner la bonne orientation
        Vector3 gravityUp = (-obj.position + transform.position).normalized; 
        obj.rotation = Quaternion.LookRotation(gravityUp);

    }

    float toRad(float degres) 
    {
        float rad;
        rad =  3.14159265f  * degres; 
        rad /=  180;

        return rad;
    }


    //Start methode
    void Start()
    {
        Init();

        for (int i = 0; i < listeDePoints.Count; i++)
        {
            Instanciate(DEGRES, listeDePoints[i].Key, listeDePoints[i].Value);
        }
    }

    void Init()
    {
        listeDePoints = new List<KeyValuePair<float, float>>();

        for (int i = 0; i < 150; i++)
        {
            float a = Random.Range(0, 360);
            float b = Random.Range(0, 360);
            listeDePoints.Add(new KeyValuePair<float, float>(a, b)); 
        }
    }

}
