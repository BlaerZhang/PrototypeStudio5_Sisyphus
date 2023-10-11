using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float scrollSpeed;

    private Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // rb2D.MoveRotation(transform.rotation * Quaternion.Euler(new Vector3(0, 0, Input.GetAxis("Mouse ScrollWheel") * scrollSpeed)));

        rb2D.AddTorque(Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);

        // transform.rotation *= Quaternion.Euler(new Vector3(0, 0, Input.GetAxis("Mouse ScrollWheel") * scrollSpeed));
    }
}
