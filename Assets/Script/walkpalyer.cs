using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class walkpalyer : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            _animator.SetBool("iswalk", true);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            _animator.SetBool("iswalk", false);

        }
        
        
    }
}
