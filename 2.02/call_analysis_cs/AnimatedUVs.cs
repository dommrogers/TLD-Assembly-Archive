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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public AnimatedUVs()
	{
	}
}
