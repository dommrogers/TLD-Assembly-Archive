using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.SaveState;

namespace NodeCanvas.Tasks.Actions;

public class Action_UnlockBadge : ActionTask
{
	public BadgeInfoType m_Badge;

	public bool m_SkipProfileSave;

	protected override string info
	{
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(BadgeUIInfo), Member = "UnlockBadge")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_UnlockBadge()
	{
	}
}
