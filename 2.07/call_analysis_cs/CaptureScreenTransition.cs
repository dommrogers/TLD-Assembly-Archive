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
	[CallerCount(Count = 0)]
	public bool HasFadeoutCaptureCompleted()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	public void StartCaptureFadeOut(UISprite background)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void DoCaptureScreen()
	{
	}

	[CallerCount(Count = 0)]
	public bool ShouldCaptureScreen()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[CallerCount(Count = 0)]
	public void MaybeStartCaptureFadeOut(UISprite background)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(Component), Member = "SendMessage")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	public void OnUpdate(UISprite background, GameObject loadingAnimation)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "MaybeResetBackgrounds")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "SetBackgroundAlpha")]
	[CallsDeduplicatedMethods(Count = 3)]
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
	[Calls(Type = typeof(CaptureScreenTransition), Member = "InitFadeOutCapture")]
	public void MaybeInitFadeOut(UISprite background, GameObject loadingAnimation)
	{
	}

	[CallerCount(Count = 0)]
	public bool IsCaptureFadingInProgress()
	{
		return default(bool);
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 0)]
	public void MaybeEnableAnimationLoading(GameObject loadingAnimation)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void SetTweenAlpha(TweenAlpha tweenAlpha, float from, float to, float duration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void InitBackgroundTweenAlpha(UISprite background, float currentAlpha)
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Enable")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "MaybeInitFadeOut")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(CaptureScreenTransition), Member = "SetBackgroundAlpha")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void InitFadeOutCapture(UISprite background, GameObject loadingAnimation)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private bool IsCaptureFading()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "InitFadeOutCapture")]
	[CalledBy(Type = typeof(CaptureScreenTransition), Member = "ResetBackgrounds")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void SetBackgroundAlpha(UIWidget widget, float alpha)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public CaptureScreenTransition()
	{
	}
}
