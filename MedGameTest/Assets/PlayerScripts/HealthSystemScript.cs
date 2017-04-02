using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystemScript : MonoBehaviour {
    public float MaxH { get; set; }
    public float CurrentH { get; set; }
    public Slider HealthB; 
	void Start ()
    {
        MaxH = 100.0f;

        CurrentH = MaxH;

        HealthB.value = CalcHealth(); 

    }
	
	void Update ()
    {
		if (Input.GetButtonDown("DamageButton"))
        {
            DamagePlayer(10.0f);
        }
	}

    void DamagePlayer(float damageAmount)
    {
        CurrentH -= damageAmount;
        HealthB.value = CalcHealth();

        if (CurrentH <= 0)
        {
            Death();
        }
    }

     float CalcHealth()
    {
        return CurrentH / MaxH; 
        
    }



    void Death()
    {
        CurrentH = 0; 
        Destroy(gameObject); 
    }




}
