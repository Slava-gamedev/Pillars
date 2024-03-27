using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeppessedCube : PlayerCharacter
{
    protected override void Jump()
    {
        Debug.Log("Too depressed to jump");
    }

    protected override void UseAbility()
    {
        Debug.Log("Magical suicide!");
        Health -= Health;
        if (Health <= 0)
            Destroy(gameObject);
    }
}
