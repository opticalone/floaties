using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidPuddle : MonoBehaviour {
    public float damage;
void OnTriggerEnter(Collider other)
    {
        var attempt = other.GetComponent<IDamagable>();
        if(attempt != null)
        {
            attempt.takeDamage(damage);
        }
    }
}
