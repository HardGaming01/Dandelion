using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    public GameObject FireFor;
    private Transform MyTransformFire;
    private float begin;
    private float over;
    //private int runfire;
    //public int RunFire
    //{
    //    get { return runfire; }
    //    set { value = runfire;}
    //}
	void Start () {
        //FireFor = GameObject.FindGameObjectWithTag("firedan");
        MyTransformFire = gameObject.GetComponent<Transform>();
        begin = 0.0f;
        over = 8.0f;
	}
	
	void Update () {
        if (begin > 0)
        {
            begin -= Time.deltaTime;
        }
        if (begin < 0)
        {
            begin = 0;
        }
        if (begin == 0)
        {
            RunTheGame();
            begin = over;
        }
	}
    private void RunTheGame()
    {
        GameObject RunDan = Instantiate(FireFor, transform.position, Quaternion.identity);
        Rigidbody2D RunRigidbidy = RunDan.GetComponent<Rigidbody2D>();
        RunRigidbidy.AddForce(new Vector2(1,1)*800);
    }
    
}
