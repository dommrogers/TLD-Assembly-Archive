using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionDefinitionTable : ScriptableObject
{
	public List<AfflictionDefinition> m_AfflictionDefinitionList;

	private Dictionary<AfflictionType, List<AfflictionDefinition>> m_AfflictionsPerTypeMap;

	private Dictionary<string, AfflictionDefinition> m_AfflictionPerNameMap;

	[CalledBy(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionDefinition GetAfflictionDefinitionByType(AfflictionType afflictionType)
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Affliction), Member = "GetDisplayName")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CalledBy(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Affliction), Member = "GetDescriptionLocId")]
	[CalledBy(Type = typeof(Affliction), Member = "GetDisplayNameLocId")]
	public AfflictionDefinition GetAfflictionDefinitionByName(string afflictionName)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallsUnknownMethods(Count = 21)]
	public void RefreshCache()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public AfflictionDefinitionTable()
	{
	}
}
