using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverArm : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] private AudioSource twistSound;
    


    private Finish _finish;

    void Start() {
       
        _finish = GameObject.FindGameObjectWithTag("Finish").GetComponent<Finish>();
    }

    public void ActivateLeverArm() {
        animator.SetTrigger("activate");
        twistSound.Play();
        _finish.Activate();
    }
}
