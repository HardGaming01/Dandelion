using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDestory2 : MonoBehaviour {
    public GameObject WaterSmall;
   
	void Start () {
      
	}
	
	void Update () {
        if (WaterSmall.transform.position.y < -560)
        {
            Destroy(WaterSmall);
        }
    }
}
