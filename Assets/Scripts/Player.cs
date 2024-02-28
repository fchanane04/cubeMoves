using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed = 1f;
    private int forUpdate = 0;
    private int forFixedUpdate = 0;
    private bool UpdateOn = true;
    private bool FixedUpdateOn = true;
    private bool LateUpdateOn = true;
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

    void OnDisable()
    {
        Debug.Log("Disable is called");
    }

    void FixedUpdate()
    {
        if (FixedUpdateOn)
        {
            FixedUpdateOn = false;
            Debug.Log("from FixedUpdate");
        }
        forFixedUpdate++;
        //Debug.Log("from FixedUpdate");
    }

    void LateUpdate()
    {
        if (LateUpdateOn)
        {
            LateUpdateOn = false;
            Debug.Log("from LateUpdate");
        }
    }

    void Update()
    {
        if (UpdateOn)
        {
            UpdateOn = false;
            Debug.Log("from Update");
        }
        forUpdate++;
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
        Debug.Log("UPDATE VARIABLE : " + forUpdate);
        Debug.Log("FIXED UPDATE VARIABLE : " + forFixedUpdate);
        Debug.Log("BYE");
    }
}
