using System.Collections;
using System.Collections.Generic;
using TimDoVat;
using UnityEngine;

public class CheckList : Singleton<CheckList>
{
    public int count = 0;

    public List<ButtonCheck> listCheck;

    void Start()
    {
        for (int i = 0; i < listCheck.Count; i++)
        {
            listCheck[i].HideIcon();
        }
    }
    
    public void AddImage(Sprite icon)
    {
        listCheck[count].SetIcon(icon);
        count++;

        CheckToHide();

        if (count == 6)
        {
            TheGameUI.Instance.ShowLose();
        }
    }

    private void CheckToHide()
    {
        if (count >= 3)
        {
            if (listCheck[count -1].Icon == listCheck[count - 2].Icon && listCheck[count - 2].Icon == listCheck[count - 3].Icon)
            {
                HideImage();
                HideImage();
                HideImage();
            }
        }

        if (count == 0)
        {
            ListQuest.Instance.Check();
        }
    }

    public void HideImage()
    {
        if (count <= 0)
        {
            return;
        }

        listCheck[count - 1].HideIcon();
        count--;
    }
}