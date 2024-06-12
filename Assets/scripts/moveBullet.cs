using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBullet : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject loseScreen;
    public GameObject zombie;
    void Start()
    {
        loseScreen = GameObject.Find("lose screen");
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * 10);
        Destroy(gameObject,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("objective"))
        {
            if (collision.gameObject.CompareTag("Player") && collision.gameObject.layer != 7)
            {
                Destroy(collision.gameObject);
                Instantiate(zombie,transform.position,transform.rotation);
                Destroy(gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
            
        }
        if (collision.gameObject.CompareTag("bus"))
        {
            loseScreen.GetComponent<LoseSceenActivate>().ActivateLoseScreen();
            Time.timeScale = 0;
        }

    }
}
