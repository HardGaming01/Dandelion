using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BruteLoadLevel : MonoBehaviour {

    public string sceneToLoad;

	public void loadLevel()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
