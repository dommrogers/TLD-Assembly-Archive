using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class StruggleBonus : MonoBehaviour
{
	public enum StruggleWeaponType
	{
		BareHands,
		Knife,
		Hatchet,
		Prybar,
		ImprovisedKnife,
		ImprovisedHatchet,
		Hammer,
		Revolver
	}

	public float m_DamageScalePercent;

	public float m_FleeChanceScale;

	public float m_TapIncrementScale;

	public float m_BleedoutMinutesScale;

	public bool m_CanPuncture;

	public StruggleWeaponType m_StruggleWeaponType;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	public StruggleBonus()
	{
	}
}
