using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
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

	[CalledBy(Type = typeof(ResolutionManager), Member = "Update")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(ResolutionManager), Member = "Update")]
	[Calls(Type = typeof(Panel_OptionsMenu), Member = "ApplyGraphicsModeAndResolution")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Screen), Member = "SetResolution")]
	private void ApplyResolution(bool fullScreen)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 9)]
	public static void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ResolutionManager()
	{
	}
}
