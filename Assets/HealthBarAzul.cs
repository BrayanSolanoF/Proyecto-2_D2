using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarAzul : MonoBehaviour
{
    public Enemy enemy;
    public Image fillImage;
    private Slider slider;


    void Awake(){


    	slider = GetComponent<Slider>();
    }

    void Update(){

    	


    	float fillValue = enemy.hp / enemy.maxHp;
    	
    	slider.value = fillValue;
    }




}
