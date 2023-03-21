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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResolutionManager), Member = "ApplyResolution")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Screen), Member = "SetResolution")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[CalledBy(Type = typeof(ResolutionManager), Member = "Update")]
	[CalledBy(Type = typeof(ResolutionManager), Member = "Update")]
	private void ApplyResolution(bool fullScreen)
	{
	}

	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Initialize()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ResolutionManager()
	{
	}
}
