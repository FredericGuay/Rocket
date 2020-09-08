using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    RigidBody myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = gameObject.GetComponent<RigidBody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputHeight = Input.GetAxis("jump");
        myRigidBody.AddForce(new Vector3(0, inputHeight, 0);
    }
}
