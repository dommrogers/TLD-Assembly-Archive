using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RealTime : MonoBehaviour
{
	public static float time
	{
		[CallerCount(Count = 17)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
	}

	public static float deltaTime
	{
		[CallerCount(Count = 21)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public RealTime()
	{
	}
}
