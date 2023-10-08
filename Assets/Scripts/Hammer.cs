using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
  [SerializeField] private Animator anim;
  [SerializeField] private string triggerName = "hammer";
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
}
