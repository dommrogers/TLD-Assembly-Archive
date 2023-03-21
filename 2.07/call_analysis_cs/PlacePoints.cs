using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlacePoints : MonoBehaviour
{
	public MinMax m_PrimaryFadeDistance;

	public MinMax m_SecondaryFadeDistance;

	public float m_FadeSpeed;

	public float m_MaxAlpha;

	public Renderer[] m_PlacePoints;

	public bool m_ShowIfFireIsBurning;

	public Fire m_AttachedFire;

	private float m_CurrentFade;

	private float m_DestinationFade;

	private float m_Distance;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PlacePoints), Member = "ShouldShow")]
	[Calls(Type = typeof(PlacePoints), Member = "UpdateColors")]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlacePoints), Member = "Update")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	private void UpdateColors(Renderer placePoint, float fade)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlacePoints), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private bool ShouldShow()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public PlacePoints()
	{
	}
}
