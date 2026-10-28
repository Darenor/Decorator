using UnityEngine;

[CreateAssetMenu(fileName = "IngredientData", menuName = "Hotdogs/Ingredient Data")]
public class IngredientData : ScriptableObject
{
    [SerializeField] private string ingredientName;
    [SerializeField] private int cost;
    [SerializeField] private int weight;

    public string IngredientName => ingredientName;
    public int Cost => cost;
    public int Weight => weight;
}
