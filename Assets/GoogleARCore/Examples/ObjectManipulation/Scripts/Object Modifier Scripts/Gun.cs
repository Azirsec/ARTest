using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
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
