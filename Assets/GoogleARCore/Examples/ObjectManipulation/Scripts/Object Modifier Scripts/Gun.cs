using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.Android;

public class Gun : MonoBehaviour
{
    //public Text ui;
    bool touchlastframe = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            //so if the button is down, you do the function
            //you put the function here`
            shoot();

        }

        if (Input.touchCount > 0 && !touchlastframe)
        {
            shoot();
            touchlastframe = true;
        }
        else if (Input.touchCount <= 0)
        {
            touchlastframe = false;
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

            if (hit.collider.gameObject.tag == "Dog")
            {
                //hit.collider.gameObject.GetComponent<Dog>().Remo();
                print("LOL me can't die");
            }
        }
    }
}
