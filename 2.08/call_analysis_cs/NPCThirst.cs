using System;
using System.Collections.Generic;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 1)]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[CallerCount(Count = 0)]
	public float GeAfflictionDehydrationRequiredLiters()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetHealthyDelta(float delta)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private bool IsDehydrated()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	private bool HasDehydrationRisk()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallsUnknownMethods(Count = 1)]
	public void ApplyTODHours(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
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

	[CalledBy(Type = typeof(NPC), Member = "DoConditionUpdate")]
	[CalledBy(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCThirst), Member = "ApplyTODHours")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 1)]
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
