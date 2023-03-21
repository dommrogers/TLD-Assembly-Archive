using System;
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public GetOtherBlackboardVariable()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
