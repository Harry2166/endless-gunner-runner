using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScrolling : MonoBehaviour
{
    //scroll speed added to all backgrounds 
    public float additionalScrollSpeed = 0f;
    //an array of all the background game objects
    public GameObject[] backgrounds;
    //an array that corresponds to the backgrounds array, where it gives the scroll speed for each individual background
    public float[] scrollSpeed;

    private void FixedUpdate()
    {

        //loops through array of objects, making scrolling occur for each
        for (int background = 0; background < backgrounds.Length; background++)
        {
            //gets the renderer for this item in the array
            Renderer rend = backgrounds[background].GetComponent<Renderer>();
            //calculates the scroll offset
            float offset = Time.time * (scrollSpeed[background] + additionalScrollSpeed);
            //offsets the texture of this item based on the offset calculated, this is not added to a previous offset.
            rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        }
    }
}
