using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstAidItem : MonoBehaviour
{
	public LocalizedString m_LocalizedProgressBarMessage;

	public LocalizedString m_LocalizedRemedyText;

	public LocalizedString m_LocalizedInspectModeUseText;

	public float m_HPIncrease;

	public bool m_ProvidesAntibiotics;

	public bool m_KillsPain;

	public bool m_AppliesBandage;

	public bool m_AppliesSutures;

	public bool m_StabalizesSprains;

	public bool m_CleansWounds;

	public float m_TimeToUseSeconds;

	public string m_UseAudio;

	public int m_UnitsPerUse;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float DeductHealing(float neededHP)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private float GetRemainingHealing()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FirstAidItem()
	{
	}
}
