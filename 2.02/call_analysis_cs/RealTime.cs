using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RealTime : MonoBehaviour
{
	public static float time
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public static float deltaTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RealTime()
	{
	}
}
