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
		[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(GetMouseScrollDelta), Member = "Do")]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(GetMouseScrollDelta), Member = "OnUpdate")]
	[CalledBy(Type = typeof(GetMouseScrollDelta), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	private void Do()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GetMouseScrollDelta()
	{
	}
}
