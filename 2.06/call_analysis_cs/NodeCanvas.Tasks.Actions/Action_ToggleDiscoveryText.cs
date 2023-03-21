using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;

namespace NodeCanvas.Tasks.Actions;

public class Action_ToggleDiscoveryText : ActionTask
{
	public bool enableDiscoveryText;

	private PanelReference<Panel_HUD> m_HUD;

	protected override string info
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_ToggleDiscoveryText()
	{
	}
}
