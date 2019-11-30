using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PawnMovement : MonoBehaviour
{
    Vector3 direction;
    static int playerScore = 0;

    private float maxLife = 8;
    private float lifetime = 0;
    private bool escaping = false;
    private float deathDuration = 3;
    private float lerpvalue = 0.1f;

    private float velocity = 0;

    // Start is called before the first frame update
    void Start()
    {
        direction.x = (float)Random.Range(-100, 101) / 1000.0f;
        direction.y = 0.2f;
        direction.z = (float)Random.Range(-100, 101) / 1000.0f;

        velocity = (float)Random.Range(30, 100) / 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        lifetime += Time.deltaTime;
        transform.position += direction.normalized * velocity * Time.deltaTime;
        transform.forward = direction.normalized;

        gameObject.GetComponentInChildren<Transform>().GetComponentInChildren<Transform>().LookAt
            (transform.position + direction.normalized * 50, Vector3.up);

        if (lifetime > maxLife)
        {
            escaping = true;
        }

        if (escaping)
        {
            lerpvalue -= (Time.deltaTime / deathDuration) / 10;
            gameObject.transform.localScale = new Vector3(lerpvalue, lerpvalue, lerpvalue);

            if (lerpvalue <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    public void Die()
    {
        //player score goes up
        playerScore++;
        //display score to screen
        GameObject.Find("PlayerScore").GetComponent<Text>().text = "Score: " + playerScore.ToString();
        Destroy(gameObject);
    }
}