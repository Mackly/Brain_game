using UnityEngine;
using System.Collections;

public class Rigidbody_test : MonoBehaviour {
    float speed = 8f;
    Vector3 movdir;
    Vector3 rotation;
    bool power;
    bool isActive;
    bool win;
    public GUIText victoire;
    public GUIText recommencer;
    public GUIText quitter;

    float cooldown;
    float activePower;

    private secret secrets; 

    void Start()
    {
        power = true;
        isActive = false;
        cooldown = 10;
        activePower = 5;
        victoire.enabled = false;
        quitter.enabled = false;
        recommencer.enabled = false;

        secrets = GetComponent<secret>();
    }

	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.F1))
        {
            Time.timeScale = 0f;
            appearsMenu();
        }

        if (Input.GetKey(KeyCode.F2))
        {
            Time.timeScale = 1f;
            disapearMenu();
        }

        if (!win)
        {
            movdir = new Vector3(0, 0, Input.GetAxisRaw("Vertical")).normalized;
            rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * 2, 0);

            if (Input.GetKey(KeyCode.Space) && power)
            {
                isActive = true;
                power = false;
            }

            if (!power)
            {
                speed = 12f;
                cooldown -= Time.deltaTime;
                activePower -= Time.deltaTime;

                if (activePower < 0)
                {
                    speed = 8f;
                    isActive = false;
                }

                if (cooldown < 0)
                {
                    power = true;
                    cooldown = 10;
                    activePower = 5;
                }
            }
        }
        else
        {
            rigidbody.Sleep();
        }
	}

    void FixedUpdate() 
    {
        rigidbody.MovePosition(rigidbody.position + speed * transform.TransformDirection(movdir) * Time.deltaTime);
        transform.localEulerAngles += rotation; 
    }

    public bool getPower()
    {
        return isActive;
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Finish")
        {
            victoire.enabled = true;
            win = true;
            quitter.enabled = true;
            recommencer.enabled = true;
        }
    }


    void appearsMenu()
    {
        victoire.enabled = true;
        quitter.enabled = true;
        recommencer.enabled = true;
        secrets.On();
    }

    void disapearMenu()
    {
        victoire.enabled = false;
        quitter.enabled = false;
        recommencer.enabled = false;
        secrets.Off();
    }
}
