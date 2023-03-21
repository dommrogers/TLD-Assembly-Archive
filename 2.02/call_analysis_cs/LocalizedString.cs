using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class LocalizedString
{
	public string m_LocalizationID;

	[CallerCount(Count = 289)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public string Text()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsSet()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public LocalizedString()
	{
	}
}
