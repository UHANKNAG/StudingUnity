using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour
{
  public Animator anim;

  void Start()
  {
    anim = GetComponent<Animator>();
  }

  private void Update()
  {
    if(Input.GetKeyDown(KeyCode.Q))
    {
      anim.SetTrigger("HipHop");
    }
    
    if(Input.GetKeyDown(KeyCode.W))
    {
      anim.SetTrigger("Rumba");
    }
    if(Input.GetKeyDown(KeyCode.E))
    {
      anim.SetTrigger("Silly");
    }
  }
}
