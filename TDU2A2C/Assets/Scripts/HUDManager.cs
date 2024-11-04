using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public Image bullet_image;
    
    
    public void ChangeColor(Color color) { 
    
        bullet_image.color = color;

    }


}
