using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Actions;

public class SetInt : ActionTask
{
	public BBParameter<int> valueA;

	public OperationMethod Operation;

	public BBParameter<int> valueB;

	protected override string info
	{
		[Calls(Type = typeof(OperationTools), Member = "GetOperationString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetInt()
	{
	}
}
