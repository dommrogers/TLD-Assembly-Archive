using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimatedUVs : MonoBehaviour
{
	public int materialIndex;

	public Vector2 uvAnimationRate;

	public Vector2 m_uvRandomOffsetAmount;

	public float m_RandomSpeedAmount;

	public string textureName;

	public bool m_TrackXWithHead;

	public Vector2 m_AdjustedAnimationRate;

	private Vector2 uvOffset;

	private Renderer m_Renderer;

	private Material m_Material;

	private float m_HeadDirection;

	private Vector2 m_CurRndOffset;

	private float m_CurRndSpeed;

	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public AnimatedUVs()
	{
	}
}
