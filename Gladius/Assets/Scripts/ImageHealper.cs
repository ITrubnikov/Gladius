using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class ImageHealper
{
    private static Image buttonImage;
    public static void sendImageToMainObject(GameObject rootGameObject, GameObject selectedButtonGameObject)
    {
        buttonImage = selectedButtonGameObject.GetComponent<Image>();
        Image component = rootGameObject.GetComponent<Image>();
        component.sprite = buttonImage.sprite;
    }
}
