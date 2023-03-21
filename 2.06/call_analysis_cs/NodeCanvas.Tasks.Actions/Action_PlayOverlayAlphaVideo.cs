using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_PlayOverlayAlphaVideo : ActionTask
{
	public string videoPathWithExt;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MoviePlayer), Member = "IsPlaying")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_PlayOverlayAlphaVideo()
	{
	}
}
