using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
namespace DefaultNamespace
{
public class Hammer : MonoBehaviour
{
    [SerializeField] private float damage = 20f;
    
  [SerializeField] private Animator anim;
  [SerializeField] private string triggerName = "hammer";
    [SerializeField] private string tagEnemy = "Enemy";
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")){
             anim.SetTrigger(triggerName);
            Debug.Log("attack");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == tagEnemy)
        {

            if (other.gameObject.TryGetComponent<IDamage>(out IDamage enemy))
            {
                enemy.Damage(damage);   
            }
           
            
            
        }
    }
}

}