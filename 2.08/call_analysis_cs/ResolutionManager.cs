using Cpp2ILInjected.CallAnalysis;
using TLD.SaveState;
using TLD.UI.Generics;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	private float m_ResetFullscreenTimer;

	private bool m_ResetFullscreen;

	private int m_TargetWidth;

	private int m_TargetHeight;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ResolutionManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Screen), Member = "SetResolution")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyResolution(bool fullScreen)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsUnknownMethods(Count = 2)]
	public static void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ResolutionManager()
	{
	}
}
