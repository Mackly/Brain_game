using UnityEngine;
using System.Collections;

public class MenuDifficulty : MenuBase {

    //Menu jouer
    public Texture NormalDifficultyMouseOver;
    public Texture HardDifficultyMouseOver;
    public Texture LegendaryDifficultyMouseOver;
    public Texture BackMouseOver;
    public Texture Still;

    public override void MouseOver(string name)
    {
        switch (name)
        {
            //Menu 2
            case "Normal":
                {
                    renderer.material.mainTexture = NormalDifficultyMouseOver;
                    break;
                }
            case "Hard":
                {
                    renderer.material.mainTexture = HardDifficultyMouseOver;
                    break;
                }
            case "Legendary":
                {
                    renderer.material.mainTexture = LegendaryDifficultyMouseOver;
                    break;
                }
            case "Retour":
                {
                    renderer.material.mainTexture = BackMouseOver;
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
                    m_Camera.transform.Rotate(new Vector3(0, 180, 0));
                    break;
                }
        }
    }
}
