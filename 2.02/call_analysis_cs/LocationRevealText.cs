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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocationRevealText), Member = "NormalizeTextureAlpha")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(LocationRevealText), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[Calls(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TMP_Text), Member = "set_font")]
	[Calls(Type = typeof(LocationRevealText), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetFontAndHide(TMP_FontAsset font)
	{
	}

	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontMaterial")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateMaterial()
	{
	}

	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "HideLocationLabel")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Queue<>), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void Hide()
	{
	}

	[CalledBy(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Queue<>), Member = "Enqueue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void StartFade(string msg)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool FadeActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(LocationRevealText), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[Calls(Type = typeof(Queue<>), Member = "Dequeue")]
	[Calls(Type = typeof(LocationRevealText), Member = "StartFade")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	private void SetTextureElementsForTime(float timeVal)
	{
	}

	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
	private void NormalizeTextureAlpha(Texture2D textureToNormalize)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public LocationRevealText()
	{
	}
}
