using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationRecorder : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AnimationRecorder()
	{
	}
}
