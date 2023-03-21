using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class LocalizedString
{
	public string m_LocalizationID;

	[CallerCount(Count = 27)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public LocalizedString()
	{
	}
}
