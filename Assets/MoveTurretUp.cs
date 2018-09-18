using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTurretUp : MonoBehaviour {
    public Transform Base;
    public Sprite turretUp;
    public Transform laser;
    public Transform turretStraightScript;
    public Transform turretDownScript;


    private void OnEnable()
    {
        ChangeBase();
        TurretStraight straight = turretStraightScript.GetComponent<TurretStraight>();
            straight.enabled = false;
        TurretDown down = turretDownScript.GetComponent<TurretDown>();
        down.enabled = false;
    }

    void ChangeBase() {
        SpriteRenderer spriteR = Base.gameObject.GetComponent<SpriteRenderer>();
        spriteR.sprite = turretUp;
        Vector3 temp = laser.rotation.eulerAngles;
        temp.z = 45.0f;
        laser.rotation = Quaternion.Euler(temp);
    }
}
