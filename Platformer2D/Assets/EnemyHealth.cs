using System.Net.NetworkInformation;
using static System.Numerics.Quaternion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Slider healthSlider;
    [SerializeField] private float totalHelath = 100f;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource hitFromPlayer;
    
    [SerializeField] private AudioSource enemyExplosion;
    private float _health;
    private RipplePostProcessor camRipple;
    public GameObject effect;
    public GameObject explosion;

    private void Start(){
        camRipple = Camera.main.GetComponent<RipplePostProcessor>();
        _health = totalHelath;
        InitHelath();
    }

    public void ReduceHealth(float damage)
    {   
         _health -= damage;
        hitFromPlayer.Play();
        animator.SetTrigger("Hit");
        Instantiate(effect, transform.position, Quaternion.identity);
        InitHelath();
        if(_health <=0f){
            //animator.SetBool("Dies", true);
            Instantiate(explosion, transform.position, Quaternion.identity);
            enemyExplosion.Play();
            Destroy(gameObject); 
            Die();
        }
    }

    private void InitHelath(){
        healthSlider.value = _health / totalHelath;
    }

    private void Die(){
        camRipple.RippleEffect();
        gameObject.SetActive(false);
    }

}
