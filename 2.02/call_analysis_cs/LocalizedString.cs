using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class LocalizedString
{
	public string m_LocalizationID;

	[CallerCount(Count = 293)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 7)]
	public LocalizedString()
	{
	}
}
