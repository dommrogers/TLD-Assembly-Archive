using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	private float m_ResetFullscreenTimer;

	private bool m_ResetFullscreen;

	private int m_TargetWidth;

	private int m_TargetHeight;

	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ResolutionManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ResolutionManager), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Screen), Member = "SetResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CallsDeduplicatedMethods(Count = 7)]
	private void ApplyResolution(bool fullScreen)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
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
