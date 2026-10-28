using UnityEngine;

public class HotdogDebugger : MonoBehaviour
{
    [Header("Базовые хот-доги")]
    [SerializeField] private HotdogData classicData;
    [SerializeField] private HotdogData cheeseData;
    [SerializeField] private HotdogData spicyData;

    [Header("Ингредиенты")]
    [SerializeField] private IngredientData picklesData;
    [SerializeField] private IngredientData onionData;

    private void Start()
    {
        DebugHotdog(new ClassicHotdog(classicData));
        DebugHotdog(new CheeseHotdog(cheeseData));
        DebugHotdog(new SpicyHotdog(spicyData));
    }

    private void DebugHotdog(Hotdog hotdog)
    {
        Debug.Log(
            $"{hotdog.GetName()} ({hotdog.GetWeight()}г) — " +
            $"{hotdog.GetCost()}р.\n" +
            "Дополнительная информация:\n" +
            $"{new PicklesDecorator(hotdog, picklesData).GetName()} " +
            $"({new PicklesDecorator(hotdog, picklesData).GetWeight()}г) — " +
            $"{new PicklesDecorator(hotdog, picklesData).GetCost()}р.\n" +
            $"{new SweetOnionDecorator(hotdog, onionData).GetName()} " +
            $"({new SweetOnionDecorator(hotdog, onionData).GetWeight()}г) — " +
            $"{new SweetOnionDecorator(hotdog, onionData).GetCost()}р."
            );
    }
}
