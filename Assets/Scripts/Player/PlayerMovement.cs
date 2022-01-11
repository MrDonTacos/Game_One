using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotate;
    private float h;
    private float v;
    public KeyCode keyLeft, keyRight;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        animator.SetFloat("Speed", v);

        transform.Translate(Vector3.forward * v * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * h * rotate * Time.deltaTime);

        if(Input.GetKey(keyLeft))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if(Input.GetKey(keyRight))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if(Input.GetMouseButtonDown(0))
        {
            transform.Rotate(Vector3.up * 180);
        }
    }
}
