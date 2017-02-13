using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour {

    Animator _animator;

    public bool _drink;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        _animator.SetBool("drink", _drink);
        print(_drink);
    }
}
