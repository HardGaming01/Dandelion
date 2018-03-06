using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPlants : MonoBehaviour {
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
    private int F;
    void Start () {
        F = 0;
        //P1 = GameObject.Find("1");
        //P2 = GameObject.Find("2");
        //P3 = GameObject.Find("3");
        //P4 = GameObject.Find("4");
        //P5 = GameObject.Find("5");
    }
	
	void Update () {
        F = F + 1;
        if (F == 0)
        {
            ChangePicture1();
        }
        else if (F == 10)
        {
            ChangePicture2();
        }
        else if (F == 20)
        {
            ChangePicture3();
        }
        else if (F == 30)
        {
            ChangePicture4();
        }
        else if (F == 40)
        {
            ChangePicture5();
            F = 0;
        }
	}
    private void ChangePicture1()
    {
        P1.SetActive(true);
        P2.SetActive(false);
        P3.SetActive(false);
        P4.SetActive(false);
        P5.SetActive(false);
    }
    private void ChangePicture2()
    {
        P1.SetActive(false);
        P2.SetActive(true);
        P3.SetActive(false);
        P4.SetActive(false);
        P5.SetActive(false);
    }
    private void ChangePicture3()
    {
        P1.SetActive(false);
        P2.SetActive(false);
        P3.SetActive(true);
        P4.SetActive(false);
        P5.SetActive(false);
    }
    private void ChangePicture4()
    {
        P1.SetActive(false);
        P2.SetActive(false);
        P3.SetActive(false);
        P4.SetActive(true);
        P5.SetActive(false);
    }
    private void ChangePicture5()
    {
        P1.SetActive(false);
        P2.SetActive(false);
        P3.SetActive(false);
        P4.SetActive(false);
        P5.SetActive(true);
    }
}
