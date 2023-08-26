using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;
    public float smoothSpeed;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - ball.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      Vector3 newPos = Vector3.Lerp(transform.position, offset + ball.position , smoothSpeed);
        transform.position = newPos;
    }
}
