using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class VistaLocation : MonoBehaviour
{
	[Serializable]
	public class MapDetailPoint
	{
		public Vector2 m_Position;

		public float m_Radius;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public MapDetailPoint()
		{
		}
	}

	public LocalizedString m_LocationName;

	public string m_MapRevealMaskPath;

	public bool m_IsAdditive;

	public Vector4 m_MaskOffsets;

	public List<MapDetailPoint> m_MapDetailPoints;

	public GearItem m_RequiredGearItem;

	private ObjectGuid m_ObjectGuid;

	private const string PLAYER_COMPARE_TAG = "Player";

	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	public void Surveyed()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VistaLocation), Member = "RemoveFromMap")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationRequiredGearItem")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowVistaNotification")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VistaLocation), Member = "RemoveFromMap")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(VistaLocation), Member = "OnDestroy")]
	[CalledBy(Type = typeof(VistaLocation), Member = "OnTriggerExit")]
	[CallerCount(Count = 2)]
	private void RemoveFromMap()
	{
	}

	[CalledBy(Type = typeof(VistaLocation), Member = "Surveyed")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "AreAnyUnsurveyedVistasActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowVistaNotification")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeHideNotification()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public VistaLocation()
	{
	}
}
