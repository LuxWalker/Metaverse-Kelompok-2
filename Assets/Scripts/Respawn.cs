using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform SpawnPoint;
    bool stop = false;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (stop) 
        {
            rb.velocity = Vector3.zero;
        }
    }
    void velocityZeroForAWhile()
    {
         stop = true;
        StartCoroutine(delayFalse());
        IEnumerator delayFalse()
        {
            yield return new WaitForSeconds(0.5f);
            stop = false;
        }
        
    }
    public void respawn()
    {
        transform.position = SpawnPoint.transform.position;
        transform.rotation = SpawnPoint.transform.rotation;
        velocityZeroForAWhile();
    }
}
