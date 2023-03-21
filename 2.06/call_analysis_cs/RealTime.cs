using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RealTime : MonoBehaviour
{
	public static float time
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	public static float deltaTime
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 18)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0f;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public RealTime()
	{
	}
}
