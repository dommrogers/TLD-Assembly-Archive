using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class CabinFeverReductionBuff : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	private float m_RiskReductionInHours;

	private float m_FeverReductionInHours;

	private float m_BuffCooldownInHours;

	private LocalizedString m_BuffAppliedText;

	private LocalizedString m_BuffTypeText;

	private string m_BuffIcon;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CabinFever), Member = "ApplyCabinFeverReductionBuff")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsUnknownMethods(Count = 1)]
	public void Apply(float fractionConsumed)
	{
	}

	[CallerCount(Count = 0)]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[CallerCount(Count = 0)]
	public CabinFeverReductionBuff()
	{
	}
}
