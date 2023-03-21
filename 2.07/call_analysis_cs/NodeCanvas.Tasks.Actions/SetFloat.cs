using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Actions;

public class SetFloat : ActionTask
{
	public BBParameter<float> valueA;

	public OperationMethod Operation;

	public BBParameter<float> valueB;

	public bool perSecond;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(OperationTools), Member = "GetOperationString")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 17)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetFloat()
	{
	}
}
