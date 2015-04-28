using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {

	public float lifetime;

	void Star ()
	{
		Destroy (gameObject, lifetime);
	}
}
