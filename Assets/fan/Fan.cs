using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public WindZone windZone;
    private Animator _anim;
    private static readonly int ON = Animator.StringToHash("On");
    private bool isOn = false;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        Debug.Log("fan on off");
        if (isOn)
        {
            SwitchOnOff(false);
        }
        else
        {
            SwitchOnOff(true);
        }

        isOn = !isOn;
    }

    public void SwitchOnOff(bool turnOn)
    {
        _anim.SetBool(ON, turnOn);
        // windZone.gameObject.SetActive(turnOn);
    }
}
