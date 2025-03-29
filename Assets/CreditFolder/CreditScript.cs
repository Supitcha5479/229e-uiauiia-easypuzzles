using UnityEngine;
using UnityEngine.UI; // Use for TextMeshPro to work

public class CreditScript : MonoBehaviour
{
    private float scrollSpeed = 50f;
    private RectTransform rectTransform;

    void Start()
    {
        // Get componet of the text
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // Move text up
        rectTransform.anchoredPosition += new Vector2(0, scrollSpeed * Time.deltaTime);
    }

    // method for trigger the credit to roll when PLayer enter the trigger area
    private void creditScreen()
    { 
      
    }// End credit screen 
    
    
}//end CreditScript