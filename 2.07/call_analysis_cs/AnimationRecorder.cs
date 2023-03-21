using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationRecorder : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AnimationRecorder()
	{
	}
}
