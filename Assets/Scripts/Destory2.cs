using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory2 : MonoBehaviour {
    public GameObject fire2;
	void Start () {
		
	}
	
	void Update () {
        if (fire2.transform.position.y > 709)
        {
            Destroy(fire2);
        }
	}
}
