using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoMove : MonoBehaviour {

    public float Speed=1;
    public string sceneToLoad;
    private float STime;
    private void Start()
    {
        STime = 3.0f;
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);
        if(transform.position.y >= 60)
        {
            //stop for 3 seconds
            Speed = 0;

            
        }
        if (Speed == 0)
        {
            STime -= Time.deltaTime;
            if (STime <= 0)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}
