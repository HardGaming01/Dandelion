using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getposition : MonoBehaviour {
    private GameObject FlyGameObject;
    private Transform MyTransform;
    private Vector3 BetweenTransform;
    private float ChangeNumber;
    private Vector3 velocity = Vector3.zero;

    void Start () {
        FlyGameObject = GameObject.Find("Flyplant");
        MyTransform = transform.GetComponent<Transform>();
        ChangeNumber = 0.4F;
	}
	
	void Update () {
        MyTransform.position = Vector3.SmoothDamp(MyTransform.position,new Vector3 (FlyGameObject.transform.position.x, FlyGameObject.transform.position.y, FlyGameObject.transform.position.z-2), ref velocity, ChangeNumber);
        
	}
}
