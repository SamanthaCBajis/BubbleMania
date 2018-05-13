using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChestOpener : MonoBehaviour
{
    Animator anim;

    void Start()
    {
    anim = GetComponent<Animator>();
    }

    public void OnPointerClick()
    {
        anim.SetTrigger("ChestOpen");
    }

}