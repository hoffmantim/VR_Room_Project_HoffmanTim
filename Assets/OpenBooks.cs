using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBooks : MonoBehaviour
{

    public GameObject Cover;
    public HingeJoint bookHinge;

    // Start is called before the first frame update
    void Start()
    {
        var bookHinge = Cover.GetComponent<HingeJoint>();
        bookHinge.useMotor = false;     
    }

    // Update is called once per frame
    public void OpenSesame()
    {
        bookHinge.useMotor = true;
        
    }
}
