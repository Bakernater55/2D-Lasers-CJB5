using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretDown : MonoBehaviour {
    public Transform Base;
    public Sprite turretDown;
    public Transform laser;
    public Transform turretStraightScript;
    public Transform turretUpScript;

    private void OnEnable()
    {
        ChangeBase();
        TurretStraight straight = turretStraightScript.GetComponent<TurretStraight>();
        straight.enabled = false;
        MoveTurretUp up = turretUpScript.GetComponent<MoveTurretUp>();
        up.enabled = false;
    }

    void ChangeBase()
    {
        SpriteRenderer spriteR = Base.gameObject.GetComponent<SpriteRenderer>();
        spriteR.sprite = turretDown;
        Vector3 temp = laser.rotation.eulerAngles;
        temp.z = 135.0f;
        laser.rotation = Quaternion.Euler(temp);
        TurretStraight straight = turretStraightScript.GetComponent<TurretStraight>();
        straight.enabled = false;
        MoveTurretUp up = turretUpScript.GetComponent<MoveTurretUp>();
        up.enabled = false;
    }
}
