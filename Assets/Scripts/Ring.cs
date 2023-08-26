using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y + 5.5f >= ball.position.y)
        {
            Destroy(gameObject);
            manager.GameScore(25);
        }
    }
}
