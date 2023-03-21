using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TMPro;
using UnityEngine;

public class LocationRevealText : MonoBehaviour
{
	public Panel_HUD m_HUD;

	public AnimationCurve m_FadeCurve;

	public float m_FadeInDelay;

	public float m_FadeTime;

	public float m_FullViewTime;

	public float m_FadeOutTime;

	public bool m_DisplayOverAccelTime;

	public Texture2D m_TextureLeftToRight;

	public Texture2D m_TextureRightToLeft;

	public Shader m_RevealShader;

	private TextMeshPro m_TMP;

	private Material m_FontMaterial;

	private bool m_HideLocationLabelLastFrame;

	private float m_AlphaOrig;

	private bool m_DoFade;

	private float m_FadeTimer;

	private Queue<string> m_Queue;

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(LocationRevealText), Member = "NormalizeTextureAlpha")]
	[Calls(Type = typeof(LocationRevealText), Member = "NormalizeTextureAlpha")]
	[Calls(Type = typeof(LocationRevealText), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[Calls(Type = typeof(TMP_Text), Member = "set_font")]
	[Calls(Type = typeof(LocationRevealText), Member = "UpdateMaterial")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	public void SetFontAndHide(TMP_FontAsset font)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontMaterial")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	private void UpdateMaterial()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "HideLocationLabel")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "HideLocationLabel")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	public void Hide()
	{
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowText")]
	public void StartFade(string msg)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool FadeActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Update")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(LocationRevealText), Member = "StartFade")]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	private void SetTextureElementsForTime(float timeVal)
	{
	}

	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	private void NormalizeTextureAlpha(Texture2D textureToNormalize)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public LocationRevealText()
	{
	}
}
