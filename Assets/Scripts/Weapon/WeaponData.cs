using UnityEngine;

[CreateAssetMenu(fileName ="Nombre del arma",menuName ="Mi juego/Nueva arma")]
public class WeaponData : ScriptableObject
{
    [Header("Valores")]
    [SerializeField] private int damage;
    [SerializeField] private int spend;
    [SerializeField] private float cooldown;
    [Header("Objetos")]
    [SerializeField] private AudioClip sound;
    [SerializeField] private RuntimeAnimatorController anim;
    [SerializeField] private Sprite icon;

    public int Damage { get { return damage; } }
    public int Spend { get { return spend; } }
    public float Cooldown { get { return cooldown; } }
    public AudioClip Sound { get { return sound; } }
    public RuntimeAnimatorController Anim { get { return anim; } }
    public Sprite Icon { get { return icon; } }
}
