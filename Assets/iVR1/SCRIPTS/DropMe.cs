using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropMe : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
	public Image containerImage;
	public Image receivingImage;
	private Color normalColor;
	public Color highlightColor = Color.yellow;
    public GameObject dropPhotos;
	
	public void OnEnable ()
	{
		if (containerImage != null)
			normalColor = containerImage.color;
	}
	
	public void OnDrop(PointerEventData data)
	{
		containerImage.color = normalColor;
		
		if (receivingImage == null)
			return;
		
		Sprite dropSprite = GetDropSprite (data);
        if (dropSprite != null && gameObject.CompareTag("box1"))
        {
            receivingImage.overrideSprite = dropSprite;
            dropPhotos.GetComponent<SubmitActivate>().box1 = true;
        }
        else if (dropSprite != null && gameObject.CompareTag("box2"))
        {
            receivingImage.overrideSprite = dropSprite;
            dropPhotos.GetComponent<SubmitActivate>().box2 = true;
        }
        else if (dropSprite != null && gameObject.CompareTag("box3"))
        {
            receivingImage.overrideSprite = dropSprite;
            dropPhotos.GetComponent<SubmitActivate>().box3 = true;
        }
    }

	public void OnPointerEnter(PointerEventData data)
	{
		if (containerImage == null)
			return;
		
		Sprite dropSprite = GetDropSprite (data);
		if (dropSprite != null)
			containerImage.color = highlightColor;
	}

	public void OnPointerExit(PointerEventData data)
	{
		if (containerImage == null)
			return;
		
		containerImage.color = normalColor;
	}
	
	Sprite GetDropSprite(PointerEventData data)
	{
		var originalObj = data.pointerDrag;
		if (originalObj == null)
			return null;
		
		var dragMe = originalObj.GetComponent<DragMe>();
		if (dragMe == null)
			return null;
		
		var srcImage = originalObj.GetComponent<Image>();
		if (srcImage == null)
			return null;
		
		return srcImage.sprite;
	}
}
