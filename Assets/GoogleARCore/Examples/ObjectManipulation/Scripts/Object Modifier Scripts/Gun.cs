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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //so if the button is down, you do the function
            //you put the function here
            //buttonPressed();
            //ui.text = "good Job you shot";
            GameObject.Find("PlayerScore").GetComponent<Text>().text = "you shot";
            Debug.Log("you shot");
            shoot();
        }
        //shoot();
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
