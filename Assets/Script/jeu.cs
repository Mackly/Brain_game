using UnityEngine;
using System.Collections;

public class jeu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Time.timeScale = 1f;
        Application.LoadLevel(Application.loadedLevel);
    }

}
