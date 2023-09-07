using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    [SerializeField] public AnimatorOverrideController blueAnim;

    public void BlueSkin()
    {
        GetComponent<Animator>().runtimeAnimatorController = blueAnim as RuntimeAnimatorController;
    }
}
