using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseButton : MonoBehaviour
{
    public Image image;

    public Sprite Icon => image == null || !image.enabled ? null : image.sprite;

    public void SetIcon(Sprite sprite)
    {
        image.enabled = true;
        image.sprite = sprite;
    }

    public void HideIcon()
    {
        image.enabled = false;
    }
}
