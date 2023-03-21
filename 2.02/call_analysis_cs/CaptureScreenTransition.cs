using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CaptureScreenTransition
{
	private bool m_CaptureFadeOutCompleted;

	private bool m_HasRequestedCapture;

	private bool m_HasStartedCapture;

	private bool m_HasStartedFadeout;

	private bool m_HasCaptured;

	private Action m_OnCaptureFinish;

	private bool m_UseCaptureFading;

	private static Texture2D m_ScreenCaptureTexture;

	[CallerCount(Count = 0)]
	public void StartCapture(Action OnCaptureFinish)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UpdateCapture()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public bool HasFadeoutCaptureCompleted()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void StartCaptureFadeOut(UISprite background)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 3)]
	public void DoCaptureScreen()
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldCaptureScreen()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	public void OnFadeoutCompleted()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "ResetBackgrounds")]
	public void OnDisable(UISprite background)
	{
	}

	[CallerCount(Count = 0)]
	public void CaptureStarted()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	public void MaybeStartCaptureFadeOut(UISprite background)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	public void OnUpdate(UISprite background, GameObject loadingAnimation)
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "MaybeResetBackgrounds")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "SetBackgroundAlpha")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "OnDisable")]
	private void ResetBackgrounds(UISprite backround)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "ResetBackgrounds")]
	public void MaybeResetBackgrounds(UISprite background)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "SetBackgroundAlpha")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "InitBackgroundTweenAlpha")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void MaybeInitFadeOut(UISprite background, GameObject loadingAnimation)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsCaptureFadingInProgress()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void MaybeEnableAnimationLoading(GameObject loadingAnimation)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void SetTweenAlpha(TweenAlpha tweenAlpha, float from, float to, float duration)
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "MaybeInitFadeOut")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "InitFadeOutCapture")]
	[CallsUnknownMethods(Count = 6)]
	private void InitBackgroundTweenAlpha(UISprite background, float currentAlpha)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "InitBackgroundTweenAlpha")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "GetFadeAlpha")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "SetBackgroundAlpha")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void InitFadeOutCapture(UISprite background, GameObject loadingAnimation)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private bool IsCaptureFading()
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "ResetBackgrounds")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "MaybeInitFadeOut")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "InitFadeOutCapture")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	private static void SetBackgroundAlpha(UIWidget widget, float alpha)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public CaptureScreenTransition()
	{
	}
}
