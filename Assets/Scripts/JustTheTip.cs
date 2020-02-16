using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustTheTip : MonoBehaviour
{
    void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject);
    }
}
