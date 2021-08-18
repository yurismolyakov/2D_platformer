using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool _isAttack;
    private bool _isAttack2;
    [SerializeField] private AudioSource attackSound;

    

    public bool IsAttack {
        get => _isAttack;
    }
    public bool IsAttack2 {
        get => _isAttack2;
    }

    public void FinishAttack(){
        _isAttack = false;
        _isAttack2 = false;
    }

    private void Update(){
        if(Input.GetKeyDown(KeyCode.E)){ 
            _isAttack = true;
            animator.SetTrigger("attack");
            attackSound.Play();
        }else if(Input.GetKeyDown(KeyCode.R)){
            _isAttack2 = true;
            animator.SetTrigger("attack2");
            attackSound.Play();
        }
    }
}
