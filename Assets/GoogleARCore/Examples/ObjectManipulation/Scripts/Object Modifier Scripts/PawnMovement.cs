using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PawnMovement : MonoBehaviour
{
    Vector3 direction;
    static int playerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        direction.x = (float)Random.Range(-100, 101) / 1000.0f;
        direction.y = 0.1f;
        direction.z = (float)Random.Range(-100, 101) / 1000.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
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