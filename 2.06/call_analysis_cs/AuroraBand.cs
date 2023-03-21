using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraBand : MonoBehaviour
{
	public float m_AnimSpeed;

	public float m_AnimStart;

	public Vector2 m_MainTexScrollRate;

	public Vector2 m_AlphaTexScrollRate;

	public float m_SpeedPercentage;

	private Color m_CurColour;

	private Vector2 uvOffsetMain;

	private Vector2 uvOffsetMask;

	private Renderer m_Renderer;

	private Material m_Material;

	private Animation m_Animation;

	private float m_LastAlpha;

	private float curLerp;

	private bool m_IsTriggeredColour;

	private Color m_TriggeredColour;

	private float m_TriggeredColourTime;

	private float m_TriggeredColourLerp;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(DownsampleAurora), Member = "RegisterAurora")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(AuroraBand), Member = "SetAlpha")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 13)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(AuroraBand), Member = "UpdateUV")]
	[Calls(Type = typeof(AuroraBand), Member = "UpdateColour")]
	[Calls(Type = typeof(AuroraBand), Member = "SetAlpha")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 12)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(AuroraBand), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AuroraManager), Member = "GetAuroraColour")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateColour()
	{
	}

	[CalledBy(Type = typeof(AuroraBand), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateUV()
	{
	}

	[CalledBy(Type = typeof(AuroraBand), Member = "Start")]
	[CalledBy(Type = typeof(AuroraBand), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsUnknownMethods(Count = 1)]
	public void SetAlpha(float alpha)
	{
	}

	[CallerCount(Count = 0)]
	public void TriggerColour(Color newColour, float lerpTime)
	{
	}

	[CallerCount(Count = 0)]
	public void ReturnColour(float lerpTime)
	{
	}

	[CallerCount(Count = 0)]
	public AuroraBand()
	{
	}
}
