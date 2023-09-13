using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    private float propellerSpeed = 1200;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.Rotate(Vector3.forward, propellerSpeed*Time.deltaTime);
    }
}
