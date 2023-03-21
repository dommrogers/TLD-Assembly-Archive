using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class RichPresenceLocInfo
{
	public PresenceType PresenceType;

	public string LocKey;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public RichPresenceLocInfo()
	{
	}
}
