﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{

    Animator animator;

    private int state;

    public int State
    {
        get
        {
            return state;
        }

        set
        {
            state = value;
        }
    }

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetFloat("State", state);


        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            state = 0;
            Debug.Log("0");
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            state = 1;
            Debug.Log("1");
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            state = 2;
            Debug.Log("2");
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            state = 3;
            Debug.Log("3");
        }
    }
}
