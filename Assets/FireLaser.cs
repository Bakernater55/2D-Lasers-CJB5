using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireLaser : MonoBehaviour {
    public Transform laser;
    public int speed;
    public int timeAlive;
    public Transform Base;
    public GameObject TurretUpButton;
    public GameObject TurretStraightButton;
    public GameObject TurretDownButton;

	// Use this for initialization
	void OnEnable () {
        laser.gameObject.SetActive(true);
	}

    private void OnDisable()
    {
        laser.gameObject.SetActive(false);
    }

    float time = 0f;
    
    // Update is called once per frame
    void Update () {
        Button upButton = TurretUpButton.GetComponent<Button>();
        Button straightButton = TurretStraightButton.GetComponent<Button>();
        Button downButton = TurretDownButton.GetComponent<Button>();
        time += Time.deltaTime;
        if (time <= timeAlive)
        {
            laser.position += laser.up * Time.deltaTime * speed;
            
            upButton.interactable = false;
            straightButton.interactable = false;
            downButton.interactable = false;

        } else
        {
            laser.position = Base.position;
            time = 0f;
            upButton.interactable = true;
            straightButton.interactable = true;
            downButton.interactable = true;
            FireLaser fire = this.gameObject.GetComponent<FireLaser>();
            fire.enabled = false;
            
        }
	}
}
