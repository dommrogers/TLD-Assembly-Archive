using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class IngestedCarryCapacityBuff : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	private float m_CarryCapacityBuffDurationInHours;

	private float m_CarryCapacityChangeKG;

	private LocalizedString m_BuffAppliedText;

	private LocalizedString m_BuffTypeText;

	private string m_BuffIcon;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ApplyIngestedCarryCapacityBuff")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsUnknownMethods(Count = 1)]
	public void Apply(float fractionConsumed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FoodEffectUtils), Member = "GetEffectFromBuff")]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public IngestedCarryCapacityBuff()
	{
	}
}
