using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName="Event/scritptableEvent")]
public class ScriptalbeEvent : ScriptableObject
{
    public UnityAction myEvent;
    public void AddListener(UnityAction val)
    {
        myEvent += val;
    } 
    public void RemoveListener(UnityAction val)
    {
        myEvent -= val;
    }

    public void InvokeEvent()
    {
        myEvent?.Invoke();
    }
}
