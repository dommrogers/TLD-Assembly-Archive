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

	public string m_ProgressBarMessage
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_RemedyText
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_InspectModeUseText
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRemainingHealing()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float DeductHealing(float neededHP)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FirstAidItem()
	{
	}
}
