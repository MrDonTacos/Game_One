using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public KeyCode keyThrow, keyJump;
    public Animator animator;
    public Rigidbody throwBall;
    public Transform transformObject;
    public GameObject ballObject;
    public float throwPower;
    private TomatoCollider ballScript;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        throwBall = transformObject.GetComponent<Rigidbody>();
        ballScript = transformObject.GetComponent<TomatoCollider>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(keyThrow))
        {
            animator.SetBool("isThrowing", true);
            // throwObject();
        }
        else
        {
            animator.SetBool("isThrowing", false);
        }
    }

    public void throwObject()
    {
        transformObject.parent = null;
        throwBall.isKinematic = false;
        throwBall.AddForce(transform.forward * throwPower, ForceMode.Impulse);
        ballScript.activated = true;
        // ballCollider.enabled;
    }

}
