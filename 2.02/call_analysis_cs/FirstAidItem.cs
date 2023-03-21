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
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 1)]
	public float GetRemainingHealing()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public float DeductHealing(float neededHP)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FirstAidItem()
	{
	}
}
