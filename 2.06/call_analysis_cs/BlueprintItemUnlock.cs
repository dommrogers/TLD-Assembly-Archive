using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;

public class BlueprintItemUnlock : MonoBehaviour
{
	public bool m_UnlockInStoryMode;

	public bool m_UnlockInSurvival;

	[Calls(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CallerCount(Count = 0)]
	public void Unlock()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	public void UnlockSilent()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "UnlockSilent")]
	[Calls(Type = typeof(BlueprintManager), Member = "UnlockSilent")]
	[Calls(Type = typeof(BlueprintManager), Member = "UnlockWithNotification")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(BlueprintManager), Member = "FindBlueprintsForGear")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private void Unlock(bool silent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public bool ShouldUnlock()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public BlueprintItemUnlock()
	{
	}
}
