using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {
    public Transform target;
    public Rigidbody myRigidbody;
    //public GameObject UnityChan;



    private float forwardForce = 1.0f;
    public Transform unitychan;

    // Use this for initialization
    void Start () {
        myRigidbody = GetComponent<Rigidbody>();
        unitychan = GameObject.Find("unitychan").transform;
    }
	
	// Update is called once per frame
	void Update () {
        target = unitychan;
        transform.LookAt(target);
        this.myRigidbody.AddForce(this.transform.forward * this.forwardForce);
        
    }
}
