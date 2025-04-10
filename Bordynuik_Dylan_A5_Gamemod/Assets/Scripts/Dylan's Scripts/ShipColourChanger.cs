using UnityEngine;


public class ShipColourChanger : MonoBehaviour
{

    private SpriteRenderer spriteRenderer; // Assign this in the Inspector
    public Color newColor; // Assign this in the Inspector

    int colorwheel = 0;

    public Color[] shipColors = new Color[] { Color.grey, Color.red, Color.blue, Color.cyan, Color.magenta, Color.green };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.C)) //when C is pressed, run through the array of colors and apply them to the player sprite renderer's color
        {
            if (spriteRenderer != null)
            {
                colorwheel = (colorwheel + 1) % shipColors.Length;
                spriteRenderer.color = shipColors[colorwheel];
            }
            
        }

    }
}
