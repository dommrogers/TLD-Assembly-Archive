using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPCThirst : MonoBehaviour
{
	private class SaveData
	{
		public float m_CurrentThirstPercentage;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public void DoUpdate(float deltaTODHours)
	{
	}

	[CallerCount(Count = 0)]
	public float GeAfflictionDehydrationRequiredLiters()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCThirst), Member = "StartDehydrationAffliction")]
	[Calls(Type = typeof(NPCCondition), Member = "ApplyDamage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void ApplyTODHours(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string serialized)
	{
	}

	[CalledBy(Type = typeof(NPC), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCThirst), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCThirst), Member = "ApplyTODHours")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NPCAfflictions), Member = "GetNPCAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "RemoveAffliction")]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void StartDehydrationAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void StartDehydrationRiskAffliction()
	{
	}

	[CallerCount(Count = 0)]
	private void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AddWaterLiters(float waterAddedLiters)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NPCThirst()
	{
	}
}
