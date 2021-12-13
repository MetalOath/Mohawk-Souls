using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinController : MonoBehaviour
{
    Animator paladinAnim;
    CharacterController paladinCC;
    float fallingTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        paladinAnim = gameObject.GetComponent<Animator>();
        paladinCC = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"));

        if (!paladinCC.isGrounded)
        {
            fallingTime += Time.deltaTime;
            if (fallingTime > 0.6f)
            {
                paladinAnim.SetBool("FallState", true);
            }
        }
        else
        {
            fallingTime = 0f;
            paladinAnim.SetBool("FallState", false);

            if (Input.GetAxis("Vertical") > 0f)
            {
                paladinAnim.SetBool("WalkState", true);
                paladinAnim.SetFloat("RunSpeed", Input.GetAxis("Fire3"));
            }
            else if (Input.GetAxis("Vertical") < 0f)
            {
                paladinAnim.SetBool("WalkBackState", true);
                paladinAnim.SetFloat("RunSpeed", Input.GetAxis("Fire3"));
            }
            else
            {
                paladinAnim.SetBool("WalkState", false);
                paladinAnim.SetBool("WalkBackState", false);
            }

            if (Input.GetAxis("Jump") > 0f)
            {
                paladinAnim.SetBool("JumpState", true);
            }
            else
            {
                paladinAnim.SetBool("JumpState", false);
            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                if(Input.GetKey(KeyCode.Q))
                {
                    paladinAnim.SetTrigger("DanceStartState");
                }
                if (Input.GetKey(KeyCode.E))
                {
                    paladinAnim.SetTrigger("DanceStopState");
                }
            }
        }
    }
}
