using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int slotNumber;
    public int point;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.name} entered slot {slotNumber} gain {point} point");
    }
}
