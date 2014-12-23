using UnityEngine;
using System.Collections;

public class PatrolHard : MonoBehaviour {

    public Transform[] patrolPoints;
    public Transform player;
    private int currentSize;
    bool follow;
    bool end = false;

	// Use this for initialization
	void Start () {
        currentSize = 0;
        follow = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!follow)
        {
            if (transform.position == patrolPoints[currentSize].position)
            {
                if (currentSize < (patrolPoints.Length - 1) && !end)
                {
                    ++currentSize;

                    if (currentSize == (patrolPoints.Length - 1))
                        end = true;
                }
                else
                {
                    --currentSize;
                    if (currentSize == 0)
                        end = false;
                }
            }

            transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentSize].position, 7 * Time.deltaTime);
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 8 * Time.deltaTime);
        }
	}


    void OnTriggerEnter(Collider obj) 
    {
        if (obj.gameObject.tag == "Player")
        {
            follow = true;
        }
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            follow = false;
        }
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
