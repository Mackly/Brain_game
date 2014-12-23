using UnityEngine;
using System.Collections;

public class MenuMain : MenuBase {

    //Menu simple
    public Texture JouerMouseOver;
    public Texture MultiMouseOver;
    public Texture TutoMouseOver;
    public Texture QuitterMouseOver;
    public Texture Still;
    
    public override void MouseOver(string name)
    {

        switch(name)
        {
            case "Multijoueur":
                {
                    renderer.material.mainTexture = MultiMouseOver;
                    break;
                }
            case "Jouer": 
                {
                    renderer.material.mainTexture = JouerMouseOver;
                    break;
                }
            case "Tutoriel":
                {
                    renderer.material.mainTexture = TutoMouseOver;
                    break;
                }
            case "quitter":
                {
                    renderer.material.mainTexture = QuitterMouseOver;
                    break;
                }
            default:
                {
                    renderer.material.mainTexture = Still;
                    break;
                }
        }
    }

    public override void ItemSelected(MenuItem item)
    {

        switch (item.gameObject.name)
        {
            case "Multijoueur":
                {
                    Application.LoadLevel(5);
                    break;
                }
            case "Jouer":
                {
                    m_Camera.transform.Rotate(new Vector3(0.0f, 180.0f, 0.0f));
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
