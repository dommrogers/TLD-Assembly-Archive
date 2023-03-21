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
		[CallsUnknownMethods(Count = 17)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(OperationTools), Member = "GetOperationString")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 6)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetFloat()
	{
	}
}
