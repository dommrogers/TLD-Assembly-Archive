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
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 2)]
	public AfflictionDefinition GetAfflictionDefinitionByType(AfflictionType afflictionType)
	{
		return null;
	}

	[CalledBy(Type = typeof(Affliction), Member = "GetDisplayNameLocId")]
	[CalledBy(Type = typeof(Affliction), Member = "SpriteNameFromAfflictionType")]
	[CalledBy(Type = typeof(Affliction), Member = "GetDescriptionLocId")]
	[CalledBy(Type = typeof(Affliction), Member = "GetDisplayName")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "Deserialize")]
	[CalledBy(Type = typeof(NPCAfflictions), Member = "AddAffliction")]
	[CalledBy(Type = typeof(NPCFreezing), Member = "DoUpdate")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionDefinition GetAfflictionDefinitionByName(string afflictionName)
	{
		return null;
	}

	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public void RefreshCache()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AfflictionDefinitionTable()
	{
	}
}
