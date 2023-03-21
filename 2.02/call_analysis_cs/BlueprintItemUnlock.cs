using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BlueprintItemUnlock : MonoBehaviour
{
	public bool m_UnlockInStoryMode;

	public bool m_UnlockInSurvival;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	public void Unlock()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	public void UnlockSilent()
	{
	}

	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "UnlockSilent")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(Utils), Member = "FindBlueprintsForGear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(BlueprintItem), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(BlueprintItem), Member = "UnlockSilent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Unlock(bool silent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool ShouldUnlock()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BlueprintItemUnlock()
	{
	}
}
