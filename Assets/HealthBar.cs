using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Player player;
    public Image fillImage;
    private Slider slider;


    void Awake(){


    	slider = GetComponent<Slider>();
    }

    void Update(){

    	


    	float fillValue = player.hp / player.maxHp;
    	
    	slider.value = fillValue;
    }




}
