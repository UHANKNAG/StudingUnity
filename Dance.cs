using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour
{
  public Animator anim;

  void Start()
  {
    anim = GetComponent<Animator>();
    // Inspector에 있는 Animator Component를 조작할 수 있게 해 주는 코드
  }

  private void Update()
  {
    // 만약 KeyCode를 누르면 Trigger가 작동하게 하는 코드
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
