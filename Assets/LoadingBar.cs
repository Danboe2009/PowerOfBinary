using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour {

	public Image cooldown;
	public bool coolingDown;
	public float waitTime = 10.0f;

	// Use this for initialization
	void Start () {
		cooldown.fillAmount = 0;		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (coolingDown == true)
		{
			//Reduce fill amount over 30 seconds
			cooldown.fillAmount += 1.0f / waitTime * Time.deltaTime;
			if (cooldown.fillAmount == 1) {
				cooldown.fillAmount = 0;
			}
		}
	}
}
