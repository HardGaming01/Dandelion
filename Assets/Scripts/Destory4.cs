using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory4 : MonoBehaviour {
    public GameObject fire4;
	void Start () {
		
	}
	
	void Update () {
        if (fire4.transform.position.y < 633)
        {
            Destroy(fire4);
        }
    }
}
