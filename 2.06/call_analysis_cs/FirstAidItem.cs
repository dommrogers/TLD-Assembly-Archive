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
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_RemedyText
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_InspectModeUseText
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetRemainingHealing()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float DeductHealing(float neededHP)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FirstAidItem()
	{
	}
}
