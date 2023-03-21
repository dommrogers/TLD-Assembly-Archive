using System;
using Cpp2ILInjected.CallAnalysis;

[Serializable]
public class RichPresenceLocInfo
{
	public PresenceType PresenceType;

	public string LocKey;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public RichPresenceLocInfo()
	{
	}
}
