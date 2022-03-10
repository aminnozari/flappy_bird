using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bird : MonoBehaviour
{
    public  float speed = 2;
    public  float force = 300;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<RigidBody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<RigidBody2D>().AddForce(Vector2.up * force );
        }
    }
    void OnCollisionEnter2D(Collision2D mehman)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
