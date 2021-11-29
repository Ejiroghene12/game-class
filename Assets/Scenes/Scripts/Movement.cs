using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MovementSpeed = 2;
    public float JumpForce = 1;
    private Rigidbody2D _rigidbody;
    public bool contro = true;
    private void Start()
    {
      _rigidbody = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        if (contro == true)
        {
            //var movement = Input.GetAxis("Horizontal");

            transform.position += new Vector3(1, 0, 0) * Time.deltaTime * MovementSpeed;

            if (Input.GetMouseButtonDown(0) && Mathf.Abs(_rigidbody.velocity.y) < 0.001f && contro)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
        }

        // { DontDestroyOnLoad(gameObject); }
    }

  


}