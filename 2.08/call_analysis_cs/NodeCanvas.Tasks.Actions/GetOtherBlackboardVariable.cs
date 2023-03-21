using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;

namespace NodeCanvas.Tasks.Actions;

public class GetOtherBlackboardVariable : ActionTask<Blackboard>
{
	public BBParameter<string> targetVariableName;

	public BBObjectParameter saveAs;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Format")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public GetOtherBlackboardVariable()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
