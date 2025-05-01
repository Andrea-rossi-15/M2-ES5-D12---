using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EnemySwitchBehaviour : MonoBehaviour
{

    public STATE StatoAttuale;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (StatoAttuale)
        {
            case STATE.IDLE:
                Debug.Log("è fermo");
                break;

            case STATE.AGGROED:
                Debug.Log("insegue il giocatore");
                break;

            case STATE.ATTACKING:
                Debug.Log("attacca il giocatore");
                break;

            case STATE.DEFEATED:
                Debug.Log("é stato sconfitto");
                break;

            default:
                Debug.Log("nessun nemico");
                break;
        }
    }

}


public enum STATE
{
    IDLE = 0,
    AGGROED = 1,
    ATTACKING = 2,
    DEFEATED = 3,


}