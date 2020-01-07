using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  Animator animator;
  void Start()
  {
      anim = GetComponent<Animator>();
  }
  void OnTriggerEnter(Collider col)
  {
      animator.SetBool("isOpen", true);
  }
    void OnTriggerExit(Collider col)
    {
        animator.SetBool("isClosed", false);
    }
}
