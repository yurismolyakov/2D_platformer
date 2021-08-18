using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float totalHealth = 100f;
    [SerializeField] private Animator animator;

    [SerializeField] private AudioSource hitFromEnemySound;
    
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private Slider healthSlider;

    private float _health;


    private void Start(){
        _health = totalHealth;
        InitHelath();
    }

   
    public void ReduceHealth(float damage)
    {
        _health -= damage;
        hitFromEnemySound.Play();
        animator.SetTrigger("HitFromEnemy");
       InitHelath();

        if (_health <= 0f)
        {
            Die();
        }
    }

    private void InitHelath(){
        healthSlider.value = _health / totalHealth;
    }

    private void Die()
    {
      
        gameObject.SetActive(false);
        gameOverCanvas.SetActive(true);
    }
}
