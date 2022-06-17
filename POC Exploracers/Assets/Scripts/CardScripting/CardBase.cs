using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Cards/CardBase", order = 1)]
public class CardBase : ScriptableObject
{
    [SerializeField] protected bool m_isHorizontal = false;
    [SerializeField] protected Sprite m_image;
    [SerializeField] protected string m_effectDescription = "wapadapadoo";

    public bool IsHorizontal { get => m_isHorizontal; }
    public Sprite Image { get => m_image; }

}
