using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

    //Menu simple
    public Texture jouerMouseOver;
    public Texture multiMouseOver;
    public Texture tutoMouseOver;
    public Texture quitterMouseOver;
    public Texture still;


    private Camera cam;

	// Use this for initialization
	void Start () {

        cam = FindObjectOfType<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void receveNotify(string name, InOut it)
    {

        switch(name)
        {
            case "Multijoueur":
                {
                    renderer.material.mainTexture = multiMouseOver;
                    break;
                }
            case "Jouer": 
                {
                    renderer.material.mainTexture = jouerMouseOver;
                    break;
                }
            case "Tutoriel":
                {
                    renderer.material.mainTexture = tutoMouseOver;
                    break;
                }
            case "quitter":
                {
                    renderer.material.mainTexture = quitterMouseOver;
                    break;
                }
            case "out":
                {
                    renderer.material.mainTexture = still;
                    break;
                }
        }
    }

    public void receveNotify(InOut it)
    {

        switch (it.gameObject.name)
        {
            case "Multijoueur":
                {
                    Application.LoadLevel(5);
                    break;
                }
            case "Jouer":
                {
                    cam.transform.Rotate(new Vector3(0, 180, 0));
                    break;
                }
            case "Tutoriel":
                {
                    Application.LoadLevel(6);
                    break;
                }
            case "quitter":
                {
                    Application.Quit();
                    break;
                }
        }
    }

}
