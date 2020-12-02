using System;
using System.Collections;
using System.Collections.Generic;
using Arbor;
using UnityEngine;

public class DirectStateJump : MonoBehaviour
{
    [SerializeField] private ArborFSM targetFSM;

    public void JumpTo(string stateName)
    {
        var state = targetFSM.FindState(stateName);
        if (state == null) return;
        if (targetFSM.currentState == state) return;
        targetFSM.Transition(state);
    }

}
