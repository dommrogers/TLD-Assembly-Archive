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
	[Calls(Type = typeof(PlacePoints), Member = "ShouldShow")]
	[Calls(Type = typeof(PlacePoints), Member = "UpdateColors")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(PlacePoints), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 12)]
	private void UpdateColors(Renderer placePoint, float fade)
	{
	}

	[CalledBy(Type = typeof(PlacePoints), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 2)]
	private bool ShouldShow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public PlacePoints()
	{
	}
}
