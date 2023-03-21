using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkEventCallbackMsg
{
	public AkCallbackInfo info;

	public GameObject sender;

	public AkCallbackType type;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AkEventCallbackMsg()
	{
	}
}
