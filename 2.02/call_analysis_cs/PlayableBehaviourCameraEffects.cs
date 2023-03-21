using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering.PostProcessing;

[Serializable]
public class PlayableBehaviourCameraEffects : PlayableBehaviour
{
	public float m_FadeIntensity;

	public float m_BlurIntensity;

	public float m_PostProcessWeigth;

	public string m_PostProcessVolumeName;

	private PostProcessVolume m_PostProcessVolume;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(PlayableBehaviourCameraEffects), Member = "MaybeSetPostProcessVolume")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayableBehaviourCameraEffects), Member = "ProcessFrame")]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeSetPostProcessVolume()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public PlayableBehaviourCameraEffects()
	{
	}
}
