using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AkEventCallbackData : ScriptableObject
{
	public List<int> callbackFlags;

	public List<string> callbackFunc;

	public List<GameObject> callbackGameObj;

	public int uFlags;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public AkEventCallbackData()
	{
	}
}
