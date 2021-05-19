using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class start : MonoBehaviour
{
    public String[] player1Elements;
    public String[] enemyElement;

    public void startRaund()
    {
        StepController.enemyElement[0] = "fire";
        StepController.enemyElement[1] = "fire";
        StepController.enemyElement[2] = "fire";
        
        player1Elements = StepController.pickElement;
        enemyElement = StepController.enemyElement;
        
        combat(player1Elements,enemyElement);
    }

    public void combat(String[] player, String[] enemy)
    {
        
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("raund: " +  i + "result: " +checkEements(player[i],enemy[i]));
        }
    }

    public String checkEements(String playerElement, String enemyElement)
    {
        String result= null;
        if (playerElement.Contains("fire"))
        {
            if (enemyElement.Contains("fire"))
            {
                result = "draw";
            }
            if (enemyElement.Contains("earth"))
            {
                result = "win";
            }
            if (enemyElement.Contains("water"))
            {
                result = "luse";
            }
        }
        if (playerElement.Contains("earth"))
        {
            if (enemyElement.Contains("fire"))
            {
                result = "luse";
            }
            if (enemyElement.Contains("earth"))
            {
                result = "draw";
            }
            if (enemyElement.Contains("water"))
            {
                result = "win";
            }
        }
        if (playerElement.Contains("water"))
        {
            if (enemyElement.Contains("fire"))
            {
                result = "win";
            }
            if (enemyElement.Contains("earth"))
            {
                result = "luse";
            }
            if (enemyElement.Contains("water"))
            {
                result = "draw";
            }
        }

        return result;
    }



}
