using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTodown : MonoBehaviour
{
    public GameObject FireFor2;
    private Transform MyTransformFire2;
    private float begin2;
    private float over2;
    private int runfire2;
   void Start()
    {
        //FireFor = GameObject.FindGameObjectWithTag("firedan");
        MyTransformFire2 = gameObject.GetComponent<Transform>();
        begin2 = 0.0f;
        over2 = 6.0f;
    }

    void Update()
    {
        if (begin2 > 0)
        {
            begin2 -= Time.deltaTime;
        }
        if (begin2 < 0)
        {
            begin2 = 0;
        }
        if (begin2 == 0)
        {
            RunTheGame2();
            begin2 = over2;
        }
    }
    private void RunTheGame2()
    {
        GameObject RunDan2 = Instantiate(FireFor2, transform.position, Quaternion.identity);
        Rigidbody2D RunRigidbidy2 = RunDan2.GetComponent<Rigidbody2D>();
        RunRigidbidy2.AddForce(new Vector2(1, 1) * -800);
    }

}

