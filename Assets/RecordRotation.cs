using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordRotation : MonoBehaviour
{
    public Transform platter;
    

    // Update is called once per frame
    void Update()
    {
        platter.Rotate(0, 3, 0, Space.World);
    }
}
