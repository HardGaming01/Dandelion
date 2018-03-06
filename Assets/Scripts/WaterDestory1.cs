using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDestory1 : MonoBehaviour {
    public GameObject WaterBig;
	void Start () {
	}
	
	void Update () {
        if (WaterBig.transform.position.y < -220)
        {
            Destroy(WaterBig);
        }
	}
}
