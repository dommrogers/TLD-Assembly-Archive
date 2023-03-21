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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MoviePlayer), Member = "Play")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_PlayOverlayAlphaVideo()
	{
	}
}
