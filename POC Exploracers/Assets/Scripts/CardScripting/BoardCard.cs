using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardCard : MonoBehaviour
{
    [SerializeField] private CardBase m_card;

    public bool GetCardOrientation()
    {
        return m_card.IsHorizontal;
    }
    public Sprite GetCardImage()
    {
        return m_card.Image;
    }
}
