using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

    public Transform laser;
    public float speed;

    void Update()
    {
        laser.position += new Vector3( Time.deltaTime * speed, 0f, 0f);
    }
}
