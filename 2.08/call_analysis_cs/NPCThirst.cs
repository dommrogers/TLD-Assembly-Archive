using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class NPCThirst : MonoBehaviour
{
	private class SaveData
	{
		public float m_CurrentThirstPercentage;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallerCount(Count = 0)]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[CallerCount(Count = 0)]
	public float GeAfflictionDehydrationRequiredLiters()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	public void ApplyTODHours(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCThirst), Member = "ApplyTODHours")]
	[CalledBy(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	private void StartDehydrationAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 1)]
	private void StartDehydrationRiskAffliction()
	{
	}

	[CallerCount(Count = 0)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	public void AddWaterLiters(float waterAddedLiters)
	{
	}

	[CallerCount(Count = 0)]
	public NPCThirst()
	{
	}
}
