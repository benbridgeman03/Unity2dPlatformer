using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{

    [SerializeField] private AnimatorOverrideController[] anims;
    private static int animPointer;
    
    private void Start()
    {
        setSkin();
    }

    public void Update()
    {
        setSkin();
    }

    public void AnimPointer0()
    {
        animPointer = 0;
    }

    public void AnimPointer1()
    {
        animPointer = 1;
    }

    public void setSkin()
    {
        GetComponent<Animator>().runtimeAnimatorController = anims[animPointer] as RuntimeAnimatorController;
    }

}
