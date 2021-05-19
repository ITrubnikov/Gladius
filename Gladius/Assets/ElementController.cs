using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ElementController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    
    public RectTransform container;
    public String nameGO;
    public String elementName;
    public bool isOpen;
    public int elementNumber;

    private GameObject[] carsInTheScene;
    // Start is called before the first frame update
    void Start()
    {
        container = transform.FindChild("Container").GetComponent<RectTransform>();  // Неподдерживаемый метод реализовать по другому
        nameGO = gameObject.name;
        isOpen = false;
        carsInTheScene = GameObject.FindGameObjectsWithTag("CheckElement");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 scale = container.localScale;
        scale.y = Mathf.Lerp(scale.y, isOpen ? 1:0, Time.deltaTime * 12);
        container.localScale = scale;
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isOpen = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isOpen = false;
    }

    public void ButtonEvent(String element)
    {
        Debug.Log("Text log b1 nameGO: " +nameGO + ", element : " + element);
        elementName = element;
      //  Debug.Log("element number: " + elementNumber);
        ImageHealper.sendImageToMainObject(gameObject, EventSystem.current.currentSelectedGameObject);
        
  
        StepController.pickElement[elementNumber] = elementName;
        // StepController.menuList[2] = "my TEST TESXT2";
        // StepController.menuList[3] = "my TEST TESXT3";
        Debug.Log("element number: " +  StepController.pickElement[elementNumber]);
     
        //StepController.menuList[1] = elementName;
        foreach (var VARIABLE in StepController.pickElement)
        {
            Debug.Log("VARIABLE number: " +  VARIABLE);
        }
        
    }
    
}
