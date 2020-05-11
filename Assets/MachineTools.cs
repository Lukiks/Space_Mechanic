using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineTools : MonoBehaviour
{
    public bool left;
    
    public MachineSC msc;

    private void OnMouseDown()
    {
        //left arrow
        if (left && msc.id > 0)
            msc.id -= 1;
        //right arrow
        if (!left && msc.id < 2)
            msc.id += 1;
    }
}
