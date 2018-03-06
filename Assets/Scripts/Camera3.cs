using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3 : MonoBehaviour {
    private GameObject FlyGameObject3;
    private Transform MyTransform3;
    private Vector3 BetweenTransform3;
    private float ChangeNumber3;
    private Vector3 velocity3 = Vector3.zero;
    public  GameObject FuZ;
    void Start () {
        FlyGameObject3 = GameObject.Find("Flyplant");
        MyTransform3 = transform.GetComponent<Transform>();
        ChangeNumber3 = 0.05F;
        FuZ = GameObject.Find("FZ");
    }
	
	void Update () {
        FuZ.transform.position = new Vector3(95, FlyGameObject3.transform.position.y, -100);
        if (FuZ.transform.position.y < -604)
        {
            MyTransform3.position = new Vector3(95, -604, -100);
        }
        else
        {
            MyTransform3.position = Vector3.SmoothDamp(MyTransform3.position, new Vector3(FuZ.transform.position.x, FuZ.transform.position.y, FuZ.transform.position.z - 10), ref velocity3, ChangeNumber3);
        }
    }
}
