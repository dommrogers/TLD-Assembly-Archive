using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RealTime : MonoBehaviour
{
	public static float time
	{
		[CallerCount(Count = 7)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
	}

	public static float deltaTime
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public RealTime()
	{
	}
}
