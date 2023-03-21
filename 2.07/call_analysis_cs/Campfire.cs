using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Interactions;
using TLD.PDID;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Campfire : FireplaceInteraction
{
	public delegate void CampFireStateDelegate();

	private PanelReference<Panel_Loading> m_Loading;

	public GameObject m_PlacedMesh;

	public GameObject m_LitMesh;

	public GameObject m_BurntMesh;

	public GameObject m_PlacementBlockColliderObj;

	public Collider m_RockRingCollider;

	public GameObject m_RockRingParent;

	public float m_RockOffsetFromGround;

	public float m_RockMaxValidOffsetFromGround;

	public string m_PlaceAudio;

	public bool m_BurnedOut;

	public CampfireState m_State;

	private bool m_IsBeingPlaced;

	private Dictionary<Transform, Vector3> m_RockPositions;

	private Dictionary<string, GameObject> m_PlacePointRocks;

	private RaycastHit[] m_RockRaycastResults;

	private Vector3 m_LastPosition;

	private float m_LargestRockOffset;

	private bool m_ValidatePlacePoints;

	private static CampfireSaveDataProxy m_CampfireSaveDataProxy;

	private Dictionary<Transform, int> m_ColliderLayerByTransform;

	public static event CampFireStateDelegate OnCampFireStateChanged
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FireplaceInteraction), Member = "Awake")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	protected override void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(FireManager), Member = "AddCampfire")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 21)]
	protected override void Start()
	{
	}

	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Physics), Member = "RaycastNonAlloc")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Fire), Member = "Serialize")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[CallsUnknownMethods(Count = 20)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public bool AreAnyRockOffsetsInvalid()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Campfire), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void SetState(CampfireState state)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Wind), Member = "IsPositionOccludedFromWind")]
	[CallsUnknownMethods(Count = 4)]
	public override bool TooWindyToStart()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnEnteredPlaceMesh()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CallsUnknownMethods(Count = 7)]
	public void OnExitedPlaceMesh()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FireplaceInteraction), Member = "AttemptToFeedFire")]
	[Calls(Type = typeof(FireplaceInteraction), Member = "AttemptToStartFire")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override void PerformFireplaceInteraction()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FireplaceInteraction), Member = "GetHoverText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override string GetHoverText()
	{
		return null;
	}

	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public Campfire()
	{
	}
}
