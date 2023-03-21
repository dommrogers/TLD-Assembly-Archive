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
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public StruggleBonus()
	{
	}
}
