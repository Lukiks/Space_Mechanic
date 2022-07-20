using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEq : MonoBehaviour
{

    public int id;

    public GameObject[] objectInHand;
    public Camera cameraPlayer;


    void Update()
    {
        for (int i = 0; i < objectInHand.Length; i++)
        {
            if (i == id)
                objectInHand[i].active = true;
            else
                objectInHand[i].active = false;
        }

        if (Input.GetMouseButton(1))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        Debug.Log("Działa");
    }
}
