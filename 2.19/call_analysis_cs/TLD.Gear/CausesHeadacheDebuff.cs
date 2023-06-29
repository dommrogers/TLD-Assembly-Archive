using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Gear;

public class CausesHeadacheDebuff : MonoBehaviour, IFoodItemBuff, IFoodEffect
{
	private HeadacheData m_HeadacheSettings;

	private float m_CausesHeadacheThreshold;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Headache), Member = "RemoveHeadache")]
	[Calls(Type = typeof(Headache), Member = "ApplyHeadache")]
	[CallsUnknownMethods(Count = 1)]
	public void Apply(float fractionConsumed)
	{
	}

	[CallerCount(Count = 0)]
	public IFoodEffect.Effect GetEffect(IFoodEffect.EffectType effectType)
	{
		return default(IFoodEffect.Effect);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CausesHeadacheDebuff()
	{
	}
}
