using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TMPro;
using UnityEngine;

public class LocationRevealText : MonoBehaviour
{
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

	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(LocationRevealText), Member = "NormalizeTextureAlpha")]
	[Calls(Type = typeof(LocationRevealText), Member = "NormalizeTextureAlpha")]
	[Calls(Type = typeof(LocationRevealText), Member = "UpdateMaterial")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[Calls(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TMP_Text), Member = "set_font")]
	[Calls(Type = typeof(LocationRevealText), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallsUnknownMethods(Count = 2)]
	public void SetFontAndHide(TMP_FontAsset font)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontMaterial")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	private void UpdateMaterial()
	{
	}

	[CalledBy(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "HideLocationLabel")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "HideLocationLabel")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	public void Hide()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[CallsDeduplicatedMethods(Count = 5)]
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

	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Update")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(LocationRevealText), Member = "StartFade")]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	private void SetTextureElementsForTime(float timeVal)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void NormalizeTextureAlpha(Texture2D textureToNormalize)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public LocationRevealText()
	{
	}
}
