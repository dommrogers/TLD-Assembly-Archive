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
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(PlacePoints), Member = "UpdateColors")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 18)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(PlacePoints), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Vector2), Member = "Distance")]
	[Calls(Type = typeof(Material), Member = "GetColor")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 21)]
	private void UpdateColors(Renderer placePoint, float fade)
	{
	}

	[CalledBy(Type = typeof(PlacePoints), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private bool ShouldShow()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlacePoints()
	{
	}
}
