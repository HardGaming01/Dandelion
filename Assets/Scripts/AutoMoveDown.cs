using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveDown : MonoBehaviour {

    public float Speed=1;
    public GameObject Canvas;

	// Use this for initialization
	void Start () {
        Canvas.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * Time.deltaTime * Speed);
        if(transform.position.y <= -33.5)
        {
            Speed = 0;
            Canvas.SetActive(true);
        }
	}
}
