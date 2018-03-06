using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour {
    public GameObject Water;
    public GameObject Swater;
    private float a = 0;
    private float b = 1;
    private float rander;
    private float giveY;
    public Transform FlowerTransform;
    void Start () {
        //Water = GameObject.FindGameObjectWithTag("water");
        a = 0;
        b = 1;
        FlowerTransform = GameObject.Find("Flyplant").GetComponent<Transform>();

    }
	
	void Update () {
        if (FlowerTransform.position.y > -405)
        {
            if (a > 0)
            {
                a -= Time.deltaTime;
            }
            if (a < 0)
            {
                a = 0;
            }
            if (a == 0)
            {
                WaterRun();
                a = b;
            }
        }
    }

    private void WaterRun()
    {
        rander = Random.Range(0, 118);
        GameObject RunDan = Instantiate(Water, new Vector3(rander, 188, -1.1f), Quaternion.identity);
        giveY = Random.Range(0, 119);
        Instantiate(Swater, new Vector3(giveY, 180, -1.1f), Quaternion.identity);
    }
}
