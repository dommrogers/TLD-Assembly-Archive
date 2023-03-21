using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionDefinitionTable : ScriptableObject
{
	public List<AfflictionDefinition> m_AfflictionDefinitionList;

	private Dictionary<AfflictionType, List<AfflictionDefinition>> m_AfflictionsPerTypeMap;

	private Dictionary<string, AfflictionDefinition> m_AfflictionPerNameMap;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionDefinition GetAfflictionDefinitionByType(AfflictionType afflictionType)
	{
		return null;
	}

	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[CalledBy(Type = typeof(Affliction), Member = "GetDisplayName")]
	[CalledBy(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[CalledBy(Type = typeof(Affliction), Member = "GetDisplayNameLocId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Affliction), Member = "GetDescriptionLocId")]
	public AfflictionDefinition GetAfflictionDefinitionByName(string afflictionName)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void RefreshCache()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionDefinitionTable()
	{
	}
}
