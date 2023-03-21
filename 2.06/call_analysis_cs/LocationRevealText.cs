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
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(LocationRevealText), Member = "UpdateMaterial")]
	[Calls(Type = typeof(LocationRevealText), Member = "NormalizeTextureAlpha")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocationRevealText), Member = "NormalizeTextureAlpha")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_HUD), Member = "ShouldHideNotification")]
	[Calls(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[Calls(Type = typeof(TMP_Text), Member = "set_font")]
	[Calls(Type = typeof(LocationRevealText), Member = "UpdateMaterial")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(LocationRevealText), Member = "Hide")]
	public void SetFontAndHide(TMP_FontAsset font)
	{
	}

	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	private void UpdateMaterial()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(GameManager), Member = "Start")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "HideLocationLabel")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "HideLocationLabel")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetFontAndHide")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	public void Hide()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowLocationReveal")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "SetTextureElementsForTime")]
	[CalledBy(Type = typeof(FullScreenMessage), Member = "ShowText")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	public void StartFade(string msg)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool FadeActive()
	{
		return default(bool);
	}

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
	[CallsUnknownMethods(Count = 2)]
	private void SetTextureElementsForTime(float timeVal)
	{
	}

	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CalledBy(Type = typeof(LocationRevealText), Member = "Awake")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = "SetPixels")]
	[CallerCount(Count = 2)]
	private void NormalizeTextureAlpha(Texture2D textureToNormalize)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public LocationRevealText()
	{
	}
}
