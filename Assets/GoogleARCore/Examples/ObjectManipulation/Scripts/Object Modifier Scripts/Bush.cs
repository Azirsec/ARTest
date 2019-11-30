using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{

    Vector3 startingPos;
    float time;
    bool vibrating;
    public int bushVibrateSpeed;

    [SerializeField] Material isvibrating;
    [SerializeField] Material notvibrating;

    GameObject animal;

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

            gameObject.GetComponent<MeshRenderer>().material = isvibrating;

            time += Time.deltaTime * bushVibrateSpeed;
            gameObject.transform.localPosition = new Vector3(startingPos.x + (Mathf.Sin(time) * 0.1f), startingPos.y, startingPos.z);

            if (time / bushVibrateSpeed >= Mathf.PI / 2)
            {
                vibrating = false;
                time = 0.0f;
                gameObject.transform.localPosition = startingPos;
                GameObject b = Instantiate(animal, transform.position, transform.rotation) as GameObject;
            }
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = notvibrating;
        }
    }

    public void spawnBird(GameObject go)
    {
        vibrating = true;
        animal = go;
    }

    public void spawnDog(GameObject go)
    {
        vibrating = true;
        animal = go;
    }
}
