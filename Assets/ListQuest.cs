using System.Collections;
using System.Collections.Generic;
using TimDoVat;
using UnityEngine;

public class ListQuest : Singleton<ListQuest>
{
    public List<ButtonQuest> listCheck;

    public List<Sprite> iconRandom;

    void Start()
    {
        RandomLevelQuest();
    }

    private void RandomLevelQuest()
    {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                listCheck[i * 3 + j].SetIcon(iconRandom[i]);
            }
        }

        foreach (var tile in listCheck)
        {
            tile.transform.SetSiblingIndex(Random.Range(0, listCheck.Count));
        }
    }

    public void Check()
    {
        foreach (var check in listCheck)
        {
            if (check.Icon != null)
            {
                return;
            }
        }

        TheGameUI.Instance.ShowWin();
    }
}