using UnityEngine;
using System.Collections;

public class Final_Player : MonoBehaviour {
    float speed = 15f;
    Vector3 movdir;
    public GUIText win;
    public GUIText myMenu;
    public GUIText timer;

    float time;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        movdir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        time += Time.deltaTime;
	}

    void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + speed * transform.TransformDirection(movdir) * Time.deltaTime);
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Finish")
        {
            rigidbody.Sleep();
            win.enabled = true;
            myMenu.enabled = true;
            timer.text = "Timer : " + (int)time + "s"; 
            timer.enabled = true;
        }
    }

}
