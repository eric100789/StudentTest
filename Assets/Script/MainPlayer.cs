using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Days
{
    Mon=3,
    Tue
}
public class MainPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    [SerializeField] private Sprite tarSp = null;
    private SpriteRenderer _spriteRenderer = null;
    private bool T=true;
    [SerializeField] private Sprite Ranibow = null;
    
    // Start is called before the first frame update
    private void Start()
    {
        while (true) ;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            
            
            
            if (T)
            {
                _spriteRenderer.sprite = Ranibow;
            }
            else
            {
                _spriteRenderer.sprite = tarSp;
                
            }
            T = !T;
            
        }
            

    }
}
