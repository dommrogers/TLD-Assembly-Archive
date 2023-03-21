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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_RequirementsDescription
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string m_Description
	{
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(LocalizedString), Member = "Text")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public NPC_UnlockablePrefabInfo()
	{
	}
}
