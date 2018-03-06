using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour {

    private AnimatorStateInfo aniState;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        aniState = animator.GetCurrentAnimatorStateInfo(0);
        if (aniState.normalizedTime >= 1.0f )
        {
            if(aniState.IsName("FadeIn"))
            {
                Destroy(gameObject);
            }
           
        }
    }
}
