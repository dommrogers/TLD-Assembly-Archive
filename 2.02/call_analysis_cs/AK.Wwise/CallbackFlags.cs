using System;
using Cpp2ILInjected.CallAnalysis;

namespace AK.Wwise;

[Serializable]
public class CallbackFlags
{
	public uint value;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public CallbackFlags()
	{
	}
}
