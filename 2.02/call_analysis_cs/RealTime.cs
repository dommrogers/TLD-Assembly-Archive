using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RealTime : MonoBehaviour
{
	public static float time
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
	}

	public static float deltaTime
	{
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 11)]
		get
		{
			return default(float);
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RealTime()
	{
	}
}
