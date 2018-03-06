using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory1 : MonoBehaviour {
    public GameObject fire1;
	void Start () {
	}
	
	void Update () {
        if (fire1.transform.position.y > 636)
        {
            Destroy(fire1);
        }
	}
}
