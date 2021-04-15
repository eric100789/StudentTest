using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{

    [SerializeField] private float Speed = 0.06f ;
    [SerializeField] private Sprite TarSp;
    [SerializeField] private Sprite BarSp;
    [SerializeField] private bool Switch = false;
    [SerializeField] private float SizeX;
    [SerializeField] private float SizeY;
    private SpriteRenderer _spriteRenderer = null;
    

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Speed);
        }


        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Switch)
            {
                _spriteRenderer.sprite = TarSp;
                SizeX /= 25f;
                SizeY /= 25f;
                gameObject.transform.localScale = new Vector3(SizeX , SizeY, 0);
                Switch = !Switch;
            }
            else
            {
                _spriteRenderer.sprite = BarSp;
                SizeX *= 25f;
                SizeY *=  25f;
                gameObject.transform.localScale = new Vector3(SizeX, SizeY, 0);
                Switch = !Switch;
            }
        }
    }
}
