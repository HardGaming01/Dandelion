using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory3 : MonoBehaviour {
    public GameObject fire3;
	void Start () {
		
	}
	
	void Update () {
        if (fire3.transform.position.y < 566)
        {
            Destroy(fire3);
        }
	}
}
