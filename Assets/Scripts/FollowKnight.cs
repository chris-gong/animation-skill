using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowKnight : MonoBehaviour {

    public Transform knight;
    public Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = knight.position + offset;
	}
}
