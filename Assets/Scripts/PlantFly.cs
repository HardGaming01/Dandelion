using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantFly : MonoBehaviour {
    public GameObject Inplant;
    private float b;
    private float o;
    private float Ro;
	void Start () {
        b = 0;
        o = 2;
	}
	
	void Update () {
        if (b > 0)
        {
            b -= Time.deltaTime;
        }
        if (b < 0)
        {
            b = 0;
        }
        if (b == 0)
        {
            PlantRun();
            b = o;
        }
    }

    private void PlantRun()
    {
        Ro = Random.Range(-5, 10);
        GameObject RunDan = Instantiate(Inplant, new Vector3(Ro, 100, 0), Quaternion.identity);
    }
}
