using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using TLD.UI.Generics;

namespace NodeCanvas.Tasks.Actions;

public class Action_RadialMenu : ActionTask
{
	public enum RadialMenuState
	{
		Enable,
		Disable
	}

	public RadialMenuState radialMenuState;

	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	protected override string info
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_RadialMenu()
	{
	}
}
