using UnityEngine;
using System.Collections;

public class Patrol_Guards : MonoBehaviour {
    public Transform[] patrolPoints;
    private int currentSize;
    bool end;

	// Use this for initialization
	void Start () {
        currentSize = 0;
        end = false;
	}
	
	// Update is called once per frame
	void Update () {

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

        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentSize].position, 10 * Time.deltaTime);
	}
}
