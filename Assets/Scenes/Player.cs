using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [Header("Speeds")]
    public float WalkSpeed = 3;

    private MoveState _moveState = MoveState.idle;
    private Transform _transform;
    private Rigidbody2D _rigidbody;
    private Animator _animatorController;
    private float _walkTime = 0;
    private Rigidbody rig;
    

    public void MoveDown()
    {
        _animatorController.Play("MoveDown");
    }

    public void MoveUp()
    {
            _animatorController.Play("MoveUp");
    }

    public void MoveLeft()
    {
        _animatorController.Play("MoveLeft");
    }

    public void MoveRight()
    {
        _animatorController.Play("MoveRight");
    }

    private void idle()
    {
        _moveState = MoveState.idle;
        _animatorController.Play("idle");
    }

    void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animatorController = GetComponent<Animator>();
    }


    void Update()
    {
        if (_rigidbody.velocity == Vector2.zero)
        {
            idle();
        }

       if (_moveState == MoveState.Walk)
        {
            if (_walkTime <= 0)
            {
                idle();
            }
        }
  
  }

    enum DirectionState
    {
        Right,
        Left,
        Up,
        Down
    }

    enum MoveState
    {
        idle,
        Walk
    }
    
    

}