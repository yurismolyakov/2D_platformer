using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{   
    [SerializeField] private float damage = 20f;
    [SerializeField] private AudioSource enemyHitSound;
    [SerializeField] private AudioSource enemyHitSound2;
    private AttackController _attackController;

    private void Start(){
        _attackController = transform.root.GetComponent<AttackController>();
    }
    
    private void OnTriggerEnter2D(Collider2D other){
        EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
        if(enemyHealth !=null && _attackController.IsAttack){
            enemyHealth.ReduceHealth(damage);
            enemyHitSound.Play();
        }else if(enemyHealth !=null && _attackController.IsAttack2){
            enemyHealth.ReduceHealth(damage);
            enemyHitSound2.Play();
            }
    }
}
