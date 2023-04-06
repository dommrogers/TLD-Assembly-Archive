using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class GetMouseScrollDelta : ActionTask
{
	public BBParameter<float> saveAs;

	public bool repeat;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetMouseScrollDelta), Member = "Do")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GetMouseScrollDelta), Member = "Do")]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(GetMouseScrollDelta), Member = "OnExecute")]
	[CalledBy(Type = typeof(GetMouseScrollDelta), Member = "OnUpdate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Do()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GetMouseScrollDelta()
	{
	}
}
