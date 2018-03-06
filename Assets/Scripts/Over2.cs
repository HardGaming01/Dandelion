using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Over2 : MonoBehaviour {
    public GameObject OverGameObject2;
    private bool over2 = false;
    public bool OVER2
    {
        get { return over2; }
        set { over2 = value; }
    }
    void Start () {
        OverGameObject2 = GameObject.FindGameObjectWithTag("Flyflower");
    }
	
	void Update () {
        if (OverGameObject2.transform.position.y > 1100)
        {
            over2 = true;
            SceneManager.LoadScene("3");
            //GetComponent<LoadLevel>().ButtonPressed();
            Debug.Log("true");
        }
    }
}
