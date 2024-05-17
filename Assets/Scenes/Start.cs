using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator mAnimator;


    

    public void ActivateAnimation()
    {
        mAnimator.SetBool("StartAnim", true);




    }

    public void DeactiveAnimation()
    {

        mAnimator.SetBool("StartAnim", false);


    }
}
