using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    //public Text ui;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //so if the button is down, you do the function
            //you put the function here
            shoot();
        }
    }

    public void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 15.0f))
        {
            if (hit.collider.gameObject.tag == "Bird")
            {
                hit.collider.gameObject.GetComponent<PawnMovement>().Die();
            }
        }
    }
}
