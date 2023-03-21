using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FireStarterItem : MonoBehaviour
{
	public float m_SecondsToIgniteTinder;

	public float m_SecondsToIgniteTorch;

	public float m_FireStartSkillModifier;

	public float m_FireStartDurationModifier;

	public float m_ConditionDegradeOnUse;

	public bool m_ConsumeOnUse;

	public bool m_RequiresSunLight;

	public bool m_IsAccelerant;

	public string m_OnUseSoundEvent;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FireStarterItem()
	{
	}
}
