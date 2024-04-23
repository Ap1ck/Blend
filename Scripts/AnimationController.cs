using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            _animator.Play("Animation1");
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            _animator.Play("Animation2");
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            _animator.Play("Animation3");
        }
    }
}
