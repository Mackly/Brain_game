using UnityEngine;
using System.Collections;

public class Menu2 : MonoBehaviour {

    //Menu jouer
    public Texture normalMouseOver;
    public Texture hardMouseOver;
    public Texture legendaryMouseOver;
    public Texture backMouseOver;
    public Texture still2;

    private Camera cam;

	// Use this for initialization
	void Start () {
        cam = FindObjectOfType<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void receveNotify(string name, InOut2 it)
    {
        switch (name)
        {
            //Menu 2
            case "Normal":
                {
                    renderer.material.mainTexture = normalMouseOver;
                    break;
                }
            case "Hard":
                {
                    renderer.material.mainTexture = hardMouseOver;
                    break;
                }
            case "Legendary":
                {
                    renderer.material.mainTexture = legendaryMouseOver;
                    break;
                }
            case "Retour":
                {
                    renderer.material.mainTexture = backMouseOver;
                    break;
                }
            case "out":
                {
                    renderer.material.mainTexture = still2;
                    break;
                }
        }
    }


    public void receveNotify(InOut2 it)
    {

        switch (it.gameObject.name)
        {
            //Menu 2
            case "Normal":
                {
                    Application.LoadLevel(1);
                    break;
                }
            case "Hard":
                {
                    Application.LoadLevel(2);
                    break;
                }
            case "Legendary":
                {
                    Application.LoadLevel(3);
                    break;
                }
            case "Retour":
                {
                    cam.transform.Rotate(new Vector3(0, 180, 0));
                    break;
                }
        }
    }
}
