using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerCharacter : MonoBehaviour
{
    protected int _health;
    public int Health { get { return _health; } set
        {
            if (value < 0)
                _health = 0;
            else
                _health = value;
        } 
    }
    protected abstract void Jump();
    protected virtual void UseAbility()
    {
        Debug.Log("Did nothing");
    }

    private void CheckForActions()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            UseAbility();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        CheckForActions();
    }
}
