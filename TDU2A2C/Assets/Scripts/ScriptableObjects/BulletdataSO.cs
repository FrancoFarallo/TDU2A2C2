using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "BulletdataSO", menuName = "Data")]
public class BulletdataSO : ScriptableObject
{
    public float speed;
    public float lifetime;
    public Material material;
    public Color color;
}
