using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    public DAMAGE_TYPE attackType;
    public DAMAGE_TYPE resistence;
    public DAMAGE_TYPE weakness;
    public int baseDamage;
    // Start is called before the first frame update
    void Start()
    {
        if (attackType == resistence)
        {
            baseDamage = baseDamage / 2;
            Debug.Log("Il nemico è resistente");

        }

        if (attackType == weakness)
        {
            baseDamage = baseDamage * 2;
            Debug.Log("Il nemico non è resistente");

        }

        Debug.Log(baseDamage);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public enum DAMAGE_TYPE
{
    SLASHING = 0,
    PIERCING = 1,
    BLUDGEONING = 2,
    MAGICAL = 3,
    FORCA = 4,
}
