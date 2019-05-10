using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour {

	void OnTriggerEnter(Collider target)
	{
		Player1Controller stats1;
		if (stats1 = target.GetComponent<Player1Controller>()){
			stats1.ChangeHealth(-1);
		}

		Player2Controller stats2;
		if (stats2 = target.GetComponent<Player2Controller>()){
			stats2.ChangeHealth(-1);
		}

	}
}
