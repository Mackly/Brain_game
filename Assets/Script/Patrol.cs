using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {

    public Transform[] PatrolPoints;
    public Transform Player;
    private int m_Index;
    bool Follow;
    bool PatrolEnded = false;
    bool Active = false;

	// Use this for initialization
	void Start () {
        m_Index = 0;
        Follow = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Active)
        {
            if (!Follow && PatrolPoints.Length > 0)
            {
                if (m_Index >= PatrolPoints.Length)
                {
                    m_Index = 0;
                    PatrolEnded = true;
                }
                else if (m_Index <= 0)
                {
                    m_Index = PatrolPoints.Length - 1;
                    PatrolEnded = false;
                }

                if (transform.position == PatrolPoints[m_Index].position)
                {
                    if (PatrolEnded)
                    {
                        --m_Index;
                    }
                    else
                    {
                        ++m_Index;
                    }
                }

                transform.position = Vector3.MoveTowards(transform.position, PatrolPoints[m_Index].position, 7 * Time.deltaTime);
            }

            else
            {
                transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 8 * Time.deltaTime);
            }
        }
	}


    void OnTriggerEnter(Collider obj) 
    {
        if (obj.gameObject.tag == "Player")
        {
            Follow = true;
            Active = true;
        }
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Follow = false;
        }
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void detected()
    {
        Active = true;
    }
}
