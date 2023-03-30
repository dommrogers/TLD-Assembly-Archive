using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationRecorder : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AnimationRecorder()
	{
	}
}
