using UnityEngine;
using System.Collections;

public class Objective : MonoBehaviour {
    
    public Vector3[] Position;
    public float RemainingTime;
    float m_TimerInitialValue;

	// Use this for initialization
	void Start () {
        m_TimerInitialValue = RemainingTime;
	}
	
	// Update is called once per frame
	void Update () {

        if ((RemainingTime -= Time.deltaTime) <= 0.0f)
        {
            RemainingTime = m_TimerInitialValue;
            if (Position.Length > 0)
            {
                transform.position = Position[Random.Range(0, Position.Length - 1)];
            }
        }
	}
}
