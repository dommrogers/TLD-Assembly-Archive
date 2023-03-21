using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ToxicFog : MonoBehaviour
{
	public LocalizedString m_ToxicFogLocalizaedString;

	public LocalizedString m_ToxicFogDescription;

	public LocalizedString m_ToxicFogTreatment;

	public LocalizedString m_ToxicFogCause;

	public string m_ToxicFogIcon;

	public float m_HealthLossPerMinute;

	public MinMax m_HeadacheStrengthRange;

	public float m_HeadachePulseDelay;

	public string m_AudioEvent;

	private float m_HeadachePulseTimer;

	private bool m_HasAffliction;

	public bool m_AllowAfflictionHeadache;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionLocId()
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public string GetAfflictionTreatment()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionDescription()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public string GetAfflictionCause()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool HasAffliction()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Log), Member = "AddAffliction")]
	[Calls(Type = typeof(PlayerCough), Member = "MaybeStart")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallsUnknownMethods(Count = 3)]
	public void StartAffliction()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerCough), Member = "Stop")]
	[Calls(Type = typeof(PlayerDamageEvent), Member = "SpawnAfflictionEvent")]
	[CallerCount(Count = 0)]
	public void StopAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 1)]
	private void ToxicFogHeadachePulse()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TimeOfDay), Member = "GetTODMinutes")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	public ToxicFog()
	{
	}
}
