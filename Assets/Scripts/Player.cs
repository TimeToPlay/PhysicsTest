using System;
using Unity.Entities;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void FixedUpdate()
    {
        Debug.Log("UP KEY PRESSED: " + Input.GetKey(KeyCode.UpArrow));
    }

}
