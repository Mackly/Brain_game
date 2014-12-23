using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {
    public Vector3[] position;

    public float timer;
    int i;
    float save;

	// Use this for initialization
	void Start () {
        i = 1;
        save = timer;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = save;
            transform.position = position[i];
            i++;
            if (i == position.Length)
                i = 0;
        }
	}
}
