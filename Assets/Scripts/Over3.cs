using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Over3 : MonoBehaviour {
    public GameObject OverGameObject3;
    private bool over3 = false;
    public bool OVER3
    {
        get { return over3; }
        set { over3 = value; }
    }

    void Start () {
        OverGameObject3 = GameObject.FindGameObjectWithTag("Flyflower");
    }
	
	void Update () {
        if (OverGameObject3.transform.position.y > 300)
        {
            over3 = true;
            SceneManager.LoadScene("4");
            Debug.Log("true");
        }
    }
}
