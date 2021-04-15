using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    private Animator _animator = null ;

    // Start is called before the first frame update
    void Start()
    {
       _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _animator.SetBool("IsWalk", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _animator.SetBool("IsWalk", false);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _animator.SetBool("IsAttack", true);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            _animator.SetBool("IsAttack", false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetBool("IsSwing", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetBool("IsSwing", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _animator.SetFloat("IsShout", 5.0f);
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            _animator.SetFloat("IsShout",0f);
        }
    }
}
