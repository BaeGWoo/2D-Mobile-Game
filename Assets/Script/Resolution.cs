using UnityEngine;

public class Resolution : MonoBehaviour
{
    private void Awake()
    {
        Rect rect = Camera.main.rect;

        float height = ((float)Screen.width / Screen.height) / (16.0f / 9.0f);
        float width = 1f / height;

        if(height<1)
        {
            rect.height = height;
            rect.y = (1f - height) / 2f;
        }

        else
        {
            rect.width = width;
            rect.x = (1f - width) / 2f;
        }

        Camera.main.rect = rect;
    }

    private void OnPreCull()
    {
        GL.Clear(true, true, Color.black);
    }
}
