using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestuirPared : MonoBehaviour {
    void OnTriggerEnter(Collider collider)
    {
        Player1Controller stats1;
        if (stats1 = collider.GetComponent<Player1Controller>())
        {
            if (stats1.getHerramienta())
            {
                Destroy(gameObject);
            }
        }
        Player2Controller stats2;
        if (stats2 = collider.GetComponent<Player2Controller>())
        {
            if (stats2.getHerramienta())
            {
                Destroy(gameObject);
            }
        }
    }
}
