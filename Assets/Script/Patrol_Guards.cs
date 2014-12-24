using UnityEngine;
using System.Collections;

public class Patrol_Guards : MonoBehaviour {
    public Transform[] PatrolPoints;
    private int m_Index;
    private bool PatrolEnded;

	// Use this for initialization
	void Start () {
        m_Index = 0;
        PatrolEnded = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (PatrolPoints.Length <= 0)
        {
            return;
        }

        if (m_Index >= PatrolPoints.Length-1)
        {
            PatrolEnded = true;
        }
        else if (m_Index <= 0)
        {
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

        transform.position = Vector3.MoveTowards(transform.position, PatrolPoints[m_Index].position, 10 * Time.deltaTime);
	}
}
