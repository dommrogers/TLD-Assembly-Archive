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
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
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
