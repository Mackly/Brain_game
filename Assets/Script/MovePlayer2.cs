using UnityEngine;
using System.Collections;

public class MovePlayer2 : MonoBehaviour {

    public float speed = 7.5f;
    public float rotation = 120f;
    private float time;
    private float timeBonus;
    public Light bonus;
    public GUIText victoire2;
    public GUIText defaite2;
    private bool reset;
    public Move player1;
    private Vector3 movdir;
    private Vector3 rotate;

    // Use this for initialization
    void Start()
    {
        bonus.enabled = false;
        reset = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!player1.getReset() && !reset) //le joueur 1 a t'il gagne et le joueur 2 a t'il gagne, si non on continue la partie
        {
            movdir = new Vector3(0, 0, Input.GetAxisRaw("Vertical2")).normalized;
            rotate = new Vector3(0, Input.GetAxisRaw("Horizontal2") * 2, 0);

            time -= Time.deltaTime;
            timeBonus -= Time.deltaTime;

            if (time < 0)
            {
                speed = 7.5f;
            }

            if (timeBonus < 0)
            {
                bonus.enabled = false;
            }
        }
        else //Si le joueur 1 a gagne ou le joueur 2 a perdu
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Application.LoadLevel("Scene random");
            }

            if (player1.getReset()) //On verifie s'il a perdu
            {
                defaite2.enabled = true;
            }
        }
    }

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + speed * transform.TransformDirection(movdir) * Time.deltaTime);
        transform.localEulerAngles += rotate;
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.collider.name == "Bonus")
        {
            speed = 15f;
            time = 5;
            Destroy(obj.gameObject);

        }

        if (obj.collider.name == "BonusLight")
        {
            bonus.enabled = true;
            timeBonus = 10;
            Destroy(obj.gameObject);
        }

    }

    void OnTriggerEnter(Collider other)
    {

        victoire2.enabled = true; 
        reset = true;

    }

    public bool getReset()
    {
        return reset;
    }
}
