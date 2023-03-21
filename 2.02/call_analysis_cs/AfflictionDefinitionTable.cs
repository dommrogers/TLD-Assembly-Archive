using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AfflictionDefinitionTable : ScriptableObject
{
	public List<AfflictionDefinition> m_AfflictionDefinitionList;

	private Dictionary<AfflictionType, List<AfflictionDefinition>> m_AfflictionsPerTypeMap;

	private Dictionary<string, AfflictionDefinition> m_AfflictionPerNameMap;

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	public AfflictionDefinition GetAfflictionDefinitionByType(AfflictionType afflictionType)
	{
		return null;
	}

	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Affliction), Member = "GetDisplayNameLocId")]
	[CalledBy(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[CalledBy(Type = typeof(Affliction), Member = "GetDescriptionLocId")]
	[CalledBy(Type = typeof(Affliction), Member = "GetDisplayName")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionDefinition GetAfflictionDefinitionByName(string afflictionName)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 17)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void RefreshCache()
	{
	}

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public AfflictionDefinitionTable()
	{
	}
}
