using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{

    Vector3 startingPos;
    float time;
    bool vibrating;
    public int bushVibrateSpeed;

    GameObject bird;

    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        startingPos = gameObject.transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        if (vibrating)
        {
            time += Time.deltaTime * bushVibrateSpeed;
            gameObject.transform.localPosition = new Vector3(startingPos.x + (Mathf.Sin(time) * 0.1f), startingPos.y, startingPos.z);

            if (time / bushVibrateSpeed >= Mathf.PI / 2)
            {
                vibrating = false;
                time = 0.0f;
                gameObject.transform.localPosition = startingPos;
                GameObject b = new GameObject();
                b = Instantiate(bird, transform.position + new Vector3(0, 0.05f, 0), transform.rotation) as GameObject;
            }
        }
    }

    public void vibrate(GameObject go)
    {
        vibrating = true;
        bird = go;
    }
}
