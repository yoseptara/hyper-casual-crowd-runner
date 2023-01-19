using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinButton : MonoBehaviour
{

    [Header(" Elements ")]
    [SerializeField] private Button thisButton;
    [SerializeField] private Image skinImage;
    [SerializeField] private GameObject lockImage;
    [SerializeField] private GameObject selector;

    private bool unlocked;

    public void Configure(Sprite skinSprite, bool unlocked)
    {
        skinImage.sprite = skinSprite;
        this.unlocked = unlocked;

        if (unlocked)
            Unlock();
        else
            Lock();
    }

    public void Unlock()
    {
        thisButton.interactable = true;
        skinImage.gameObject.SetActive(true);
        lockImage.SetActive(false);

        unlocked = true;
    }

    private void Lock()
    {
        thisButton.interactable = false;
        skinImage.gameObject.SetActive(false);
        lockImage.SetActive(true);

    }

    public void Select()
    {
        selector.SetActive(true);
    }

    public void Deselect()
    {
        selector.SetActive(false);
    }

    public Button GetButton()
    {
        return thisButton;
    }

    public bool IsUnlocked()
    {
        return unlocked;
    }
}
