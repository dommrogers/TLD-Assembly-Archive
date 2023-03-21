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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FireplaceInteraction), Member = "Awake")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	protected override void Awake()
	{
	}

	[Calls(Type = typeof(FireManager), Member = "AddCampfire")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	protected override void Start()
	{
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "IsChildOf")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowKeyNotFoundException")]
	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(ObjectGuid), Member = "MaybeRuntimeRegister")]
	[Calls(Type = typeof(Physics), Member = "RaycastNonAlloc")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Fire), Member = "Serialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Fire), Member = "Deserialize")]
	[Calls(Type = typeof(Campfire), Member = "SetState")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeRegister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public bool AreAnyRockOffsetsInvalid()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Campfire), Member = "Deserialize")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
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
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceMesh")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
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
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override void PerformFireplaceInteraction()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(FireplaceInteraction), Member = "GetHoverText")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override string GetHoverText()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(BaseInteraction), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public Campfire()
	{
	}
}
