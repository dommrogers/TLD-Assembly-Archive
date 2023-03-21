using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCThirst : MonoBehaviour
{
	private class SaveData
	{
		public float m_CurrentThirstPercentage;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SaveData()
		{
		}
	}

	public float m_FullThirstAsLiters;

	public float m_InitialThirstPercentage;

	public float m_ThirstIncreasePerHour;

	public float m_DehydrationRiskThresholdPercentage;

	public float m_MinimumWaterFromPlayerLiters;

	public bool m_AlwaysHydrated;

	[NonSerialized]
	public NPC m_NPC;

	[NonSerialized]
	public float m_CurrentThirstPercentage;

	private bool m_HasInitialized;

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[CallerCount(Count = 0)]
	public float GeAfflictionDehydrationRequiredLiters()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public float GetHealthyDelta(float delta)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private bool IsDehydrated()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	private bool HasDehydrationRisk()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public void ApplyTODHours(float delta)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Deserialize(string serialized)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(NPC), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCThirst), Member = "ApplyTODHours")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CalledBy(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void StartDehydrationAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 2)]
	private void StartDehydrationRiskAffliction()
	{
	}

	[CallerCount(Count = 0)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public void AddWaterLiters(float waterAddedLiters)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public NPCThirst()
	{
	}
}
