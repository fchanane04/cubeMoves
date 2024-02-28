using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed = 1f;
    // Start is called before the first frame update

    void Awake()
    {
        Debug.Log("Awake() called for " + gameObject.name);
        Debug.Log("Awake() called for " + gameObject.tag);
        //tag and name are diff
    }
    void Start()
    {
        Debug.Log("from Start");
        rb = GetComponent<Rigidbody>();
    }
    void OnEnable()
    {
        Debug.Log("from OnEnable");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
         //if i added some xf it means => seconds to wait
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(+moveSpeed, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Destroy(gameObject);
        }
    }
    void OnDestroy()
    {
        // is automatically called when we destroy the gameObject
        Debug.Log("BYE");
    }
}
