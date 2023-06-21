using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class LocalizedString
{
	public string m_LocalizationID;

	[CallerCount(Count = 41)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string Text()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSet()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LocalizedString()
	{
	}
}
