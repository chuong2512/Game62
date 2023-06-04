using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonQuest : BaseButton
{
    private Button _button;

    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ClickButton);
    }

    private void ClickButton()
    {
        if (Icon != null)
        {
            CheckList.Instance.AddImage(Icon);
            HideIcon();
        }
    }
}