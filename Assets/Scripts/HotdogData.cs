using UnityEngine;

[CreateAssetMenu(fileName = "HotdogData", menuName = "Hotdogs/Hotdog Data")]
public class HotdogData : ScriptableObject
{
    [SerializeField] private string hotdogName;
    [SerializeField] private int cost;
    [SerializeField] private int weight;

    public string HotdogName => hotdogName;
    public int Cost => cost;
    public int Weight => weight;
}
