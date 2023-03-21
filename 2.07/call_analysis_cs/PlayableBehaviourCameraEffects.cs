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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MaybeSetPostProcessVolume()
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public PlayableBehaviourCameraEffects()
	{
	}
}
