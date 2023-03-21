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

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "UnlockSilent")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(BlueprintItem), Member = "UnlockWithNotification")]
	[Calls(Type = typeof(BlueprintItem), Member = "UnlockSilent")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "FindBlueprintsForGear")]
	private void Unlock(bool silent)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public bool ShouldUnlock()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BlueprintItemUnlock()
	{
	}
}
