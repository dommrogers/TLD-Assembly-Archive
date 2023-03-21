using System;
using Cpp2ILInjected.CallAnalysis;

namespace AK.Wwise;

[Serializable]
public class CallbackFlags
{
	public uint value;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public CallbackFlags()
	{
	}
}
