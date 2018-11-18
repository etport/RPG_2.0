using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;


public class CameraFocusTarget : MonoBehaviour {


    public DynamicCharacterAvatar target; 
    public HumanBodyBones focusPoint; 
    Animator animator;

    // Use this for initialization
    void Start ()
    {
        animator = target.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (gameObject.GetComponent<Camera>().isActiveAndEnabled)
        {
            Transform head = animator.GetBoneTransform(focusPoint);
            transform.LookAt(head);

        }
    }
}
