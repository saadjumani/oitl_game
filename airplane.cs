using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class airplane : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    public float turnSpeed = 2;
    public int score;

    public GameObject ScoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);

        if(speed < maxSpeed)
        {
            speed = speed + 0.01f;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(0, 0, turnSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, -turnSpeed);
        }
    }

    void OnCollisionEnter(Collision collisionData)
    {

    }

    void OnTriggerEnter()
    {
        score = score + 1;
        ScoreDisplay.GetComponent<TextMeshProUGUI>().SetText(score.ToString());
    }
}
