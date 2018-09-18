using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretStraight : MonoBehaviour {

    public Transform Base;
    public Sprite turretStraight;
    public Transform laser;
    public Transform turretUpScript;
    public Transform turretDownScript;
  

    private void OnEnable()
    {
        ChangeBase();
        MoveTurretUp up = turretUpScript.GetComponent<MoveTurretUp>();
        up.enabled = false;
        TurretDown down = turretDownScript.GetComponent<TurretDown>();
        down.enabled = false;
    }

    void ChangeBase()
    {
        SpriteRenderer spriteR = Base.gameObject.GetComponent<SpriteRenderer>();
        spriteR.sprite = turretStraight;
        Vector3 temp = laser.rotation.eulerAngles;
        temp.z = 90.0f;
        laser.rotation = Quaternion.Euler(temp);
    }
}
