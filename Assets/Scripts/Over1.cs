using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Over1 : MonoBehaviour {
    private GameObject OverGameObject;
    private bool over1=false;
    public bool OVER1
    {
        get { return over1; }
        set { over1 = value; }
    }
	void Start () {
        OverGameObject = GameObject.FindGameObjectWithTag("Flyflower");
	}
	
	void Update () {
        if (OverGameObject.transform.position.y > 115)
        {
            over1 = true;
            SceneManager.LoadScene("2");
            //GetComponent<LoadLevel>().ButtonPressed();
            Debug.Log("true");
        }
	}
}
