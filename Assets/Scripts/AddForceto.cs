using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceto : MonoBehaviour {
    private static AddForceto Instance;
    private Rigidbody2D Flyplant;
	void Start () {
        Flyplant = gameObject.GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        if (GetComponent<MicInput>().Volume > 0.2)
        {
            Flyplant.AddForce(new Vector2(0, 1) * 400);
        }
        Flyplant.AddForce(new Vector2(Input.acceleration.x * 400, 0));
    }

    private void Awake()
    {
        Instance = this;
    }

    private void begin()
    {
        AndroidJavaClass anj = new AndroidJavaClass("play");
        AndroidJavaObject ano = anj.GetStatic<AndroidJavaObject>("activity");
        ano.Call("stop");

    }
    //private void RoTaTion()
    //{
    //    Input.acceleration.
    //}
}
