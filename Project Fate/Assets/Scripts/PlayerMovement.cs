using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0.0f, 1f)]
    public float moveSpeed;

    public Animator anim;

    private void Awake()
    {
        anim = transform.GetChild(0).GetChild(0).GetComponent<Animator>();
    }

    private void Update()
    {
        anim.SetFloat("MoveSpeed", moveSpeed);
    }
}
