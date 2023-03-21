using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockBadge : ActionTask
{
	public BadgeInfoType m_Badge;

	public bool m_SkipProfileSave;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_UnlockBadge()
	{
	}
}
