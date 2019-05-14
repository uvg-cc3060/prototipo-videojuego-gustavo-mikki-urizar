using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp_Object : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        Player1Controller stats1;
        if(stats1 = collider.GetComponent<Player1Controller>())
        {
            stats1.agarrarHerramienta();
            Destroy(gameObject);
        }
        Player2Controller stats2;
        if (stats2 = collider.GetComponent<Player2Controller>())
        {
            stats2.agarrarHerramienta();
            Destroy(gameObject);
        }
    }
}
