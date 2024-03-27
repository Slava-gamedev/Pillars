using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicalCube : PlayerCharacter
{
    [SerializeField]
    private Rigidbody _rb;
    [SerializeField]
    private float _jumpPower=10;

    protected override void Jump()
    {
        if (_rb != null)
        {
            _rb.AddForce(Vector3.up * _jumpPower);
        }
    }

    protected override void UseAbility()
    {
        Debug.Log("Perfect tax evasion!");
    }
}
