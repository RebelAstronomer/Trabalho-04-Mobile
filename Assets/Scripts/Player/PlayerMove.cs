using System;
using System.Collections;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 5;
    public float horizontalSpeed = 2.5f;
    public float smoothness = 5;
    static public bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public static GameObject playerObject;
    public float jumpForce = 3;
    public float jumpDelay = 0.45f;

    void Start()
    {
        playerObject = this.gameObject;
    }

    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector3.forward, Space.World);

        if (canMove == true)
        {

            if (Input.GetKeyDown(KeyCode.A))
            {
                if (gameObject.transform.position.x > -2.5f)
                {
                    gameObject.transform.Translate(new Vector3(-2.5f, 0, 0), Space.World);
                }
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                if (gameObject.transform.position.x < 2.5f)
                {
                    gameObject.transform.Translate(new Vector3(2.5f, 0, 0), Space.World);
                }
            }


            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (isJumping == false)
                {
                    isJumping = true;
                    StartCoroutine(JumpSequence());
                }
            }
        }

        if (isJumping == true)
        {
            if (comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpForce, Space.World);
            }
            else
            {
                transform.Translate(Vector3.up * Time.deltaTime * -jumpForce, Space.World);
            }
        }

    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(jumpDelay);
        comingDown = true;
        yield return new WaitForSeconds(jumpDelay);
        isJumping = false;
        comingDown = false;
    }
}
