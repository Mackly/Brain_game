using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float speed = 15f;
    private float time;
    private float timeBonus;
    public Light bonus;
    public GUIText victoire;
    public GUIText defaite;
    private bool reset;
    public MovePlayer2 player2;
    public GUITexture boost;
    public GUITexture m_Light;
    private Vector3 movdir;
    private Vector3 rotate;

    public GUIText quit;
    public GUIText retry;


	// Use this for initialization
	void Start () {
        bonus.enabled = false;
        reset = false;
        boost.enabled = false;
        retry.enabled = false;
        quit.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{

        if (!player2.getReset() && !reset)
        {
            movdir = new Vector3(0, 0, Input.GetAxisRaw("Vertical")).normalized;
            rotate = new Vector3(0, Input.GetAxisRaw("Horizontal") * 2, 0);

            time -= Time.deltaTime;
            timeBonus -= Time.deltaTime;

            if (time < 0)
            {
                speed = 7.5f;
                boost.enabled = false;
            }

            if (timeBonus < 0)
            {
                bonus.enabled = false;
                m_Light.enabled = false;
            }
        }
        else 
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Application.LoadLevel("Scene random");
            }

            if (player2.getReset())
            {
                retry.enabled = true;
                quit.enabled = true;
                defaite.enabled = true;
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
            boost.enabled = true;
            
        }

        if (obj.collider.name == "BonusLight")
        {
            bonus.enabled = true;
            timeBonus = 10;
            Destroy(obj.gameObject);
            m_Light.enabled = true;
        }

    }

    void OnTriggerEnter(Collider other) 
    {
        rigidbody.Sleep();
        victoire.enabled = true;
        reset = true;
        retry.enabled = true;
        quit.enabled = true;
       
    }

    public bool getReset()
    {
        return reset;
    }
}
