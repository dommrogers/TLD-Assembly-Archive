using Cpp2ILInjected.CallAnalysis;

public class NPC_UnlockablePrefabInfo
{
	public LocalizedString m_LocalizedDisplayName;

	public LocalizedString m_LocalizedRequirementsDescription;

	public LocalizedString m_LocalizedDescription;

	public int m_TrustToUnlock;

	public bool m_Unlocked;

	public string m_DisplayName
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		get
		{
			return null;
		}
	}

	public string m_RequirementsDescription
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

	public string m_Description
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Localization), Member = "Get")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public NPC_UnlockablePrefabInfo()
	{
	}
}
