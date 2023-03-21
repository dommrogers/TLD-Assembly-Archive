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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ResolutionManager), Member = "Update")]
	[CalledBy(Type = typeof(ResolutionManager), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Screen), Member = "SetResolution")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	private void ApplyResolution(bool fullScreen)
	{
	}

	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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
