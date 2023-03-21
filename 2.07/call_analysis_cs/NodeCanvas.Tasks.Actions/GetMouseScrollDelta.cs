using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class GetMouseScrollDelta : ActionTask
{
	public BBParameter<float> saveAs;

	public bool repeat;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GetMouseScrollDelta), Member = "OnUpdate")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(GetMouseScrollDelta), Member = "OnExecute")]
	private void Do()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GetMouseScrollDelta()
	{
	}
}
