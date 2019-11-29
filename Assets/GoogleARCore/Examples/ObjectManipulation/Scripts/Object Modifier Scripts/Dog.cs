using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    Vector3 startingPos;

    public float speed;

    float countdown;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
        countdown = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown > 0.0f)
        {
            gameObject.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));

            if (gameObject.transform.position.y > startingPos.y + 1 * gameObject.transform.localScale.x)
            {
                gameObject.transform.SetPositionAndRotation(startingPos + new Vector3(0, 1 * gameObject.transform.localScale.x, 0), gameObject.transform.rotation);
                countdown -= Time.deltaTime;
            }
        }

        else
        {
            gameObject.transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));

            if (gameObject.transform.position.y < startingPos.y - 0.1f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
