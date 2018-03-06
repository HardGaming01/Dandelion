using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour {

    public GameObject FadeObject;
    public Animator FadeAnimator;
    public string LevelToLoad;
    public AnimatorStateInfo aniState;

    private void Start()
    {
        FadeAnimator = FadeObject.GetComponent<Animator>();
    }

    public void ButtonPressed()
    {
        FadeObject.transform.SetAsLastSibling();
        FadeAnimator.SetTrigger("Pressed");
    }
    private void Update()
    {
        aniState = FadeAnimator.GetCurrentAnimatorStateInfo(0);
        if(aniState.normalizedTime >= 1.0f && aniState.IsName("FadeOut"))
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
