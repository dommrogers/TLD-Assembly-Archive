using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NPC_UnlockablePrefab : MonoBehaviour
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedRequirementsDescription;

	public LocalizedString m_LocalizedDescription;

	public int m_TrustToUnlock;

	public string m_DisplayName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_RequirementsDescription
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(NPC_UnlockableTracker), Member = "AddUnlockable")]
	[CallsUnknownMethods(Count = 6)]
	public NPC_UnlockablePrefabInfo GetPrefabInfo()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public NPC_UnlockablePrefab()
	{
	}
}
