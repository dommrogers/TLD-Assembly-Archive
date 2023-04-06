using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class VideoIsPlaying : ConditionTask
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public VideoIsPlaying()
	{
	}
}
