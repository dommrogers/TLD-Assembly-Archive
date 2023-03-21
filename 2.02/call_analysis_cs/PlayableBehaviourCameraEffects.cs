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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayableBehaviourCameraEffects), Member = "MaybeSetPostProcessVolume")]
	[Calls(Type = typeof(CameraFade), Member = "SetScreenOverlayColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(CameraEffects), Member = "BlurSetSize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[CalledBy(Type = typeof(PlayableBehaviourCameraEffects), Member = "ProcessFrame")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeSetPostProcessVolume()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public PlayableBehaviourCameraEffects()
	{
	}
}
