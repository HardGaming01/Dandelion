using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDestory : MonoBehaviour {
    public GameObject DePlant;
	void Start () {
	}
	
	void Update () {
		if(DePlant.transform.position.y<-213)
        {
            DestroyObject(DePlant);
        }
	}
}
