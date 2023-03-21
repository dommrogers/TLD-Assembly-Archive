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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
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

	[CalledBy(Type = typeof(GetMouseScrollDelta), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GetMouseScrollDelta), Member = "OnExecute")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	private void Do()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GetMouseScrollDelta()
	{
	}
}
