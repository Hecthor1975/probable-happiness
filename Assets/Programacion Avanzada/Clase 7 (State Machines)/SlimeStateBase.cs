using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeStateBase : StateBase<SlimeController>
{
  public bool DetectPlayer()
    {
        if(Random.Range(0, 100) == 0)
        {
            return false;

        }
        return true;
    }
}
