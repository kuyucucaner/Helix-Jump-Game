using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject splashPrefab;
    public Rigidbody rigidBody;
    public float jumpForce;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        rigidBody.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.2f,0f),transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Material Name : " + materialName);


        if(materialName == "Unsafe Color (Instance)")
        {
            Debug.Log("Game Over!");
            gameManager.RestartGame();
        }
        else if(materialName == "Last Ring (Instance)")
        {
            Debug.Log("Next Level!");
        }
    }
}
