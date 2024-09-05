using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Edison : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exit");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Stay");
    }
    private void OnTriggerEnter2D(Collision2D collision)
    {
        Debug.Log("Enter");
    }
    private void OnTriggerEixt2D(Collision2D collision)
    {
        Debug.Log("Exit");
    }
    private void OnTriggerStay2D(Collision2D collision)
    {
        Debug.Log("Stay");
    }
    
}
