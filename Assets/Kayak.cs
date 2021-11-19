using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Kayak : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{    
    public GameObject parent;
    public Button parentBttn;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        ((IPointerEnterHandler)parentBttn).OnPointerEnter(eventData);
        
        GameObject Child1 = parent.transform.GetChild(0).gameObject; //Text
        Child1.GetComponent<Text>().enabled = false;
        GameObject Child2 = parent.transform.GetChild(1).gameObject; //Image
        Child2.GetComponent<Image>().enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ((IPointerExitHandler)parentBttn).OnPointerExit(eventData);
        GameObject Child1 = parent.transform.GetChild(0).gameObject; //Text
        Child1.GetComponent<Text>().enabled = true;
        GameObject Child2 = parent.transform.GetChild(1).gameObject; //Image
        Child2.GetComponent<Image>().enabled = false;

        Child1 = null;
        Child2 = null;
    }    
}
