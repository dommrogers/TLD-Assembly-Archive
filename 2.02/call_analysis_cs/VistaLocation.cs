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
		[CallerCount(Count = 2)]
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
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	public void Surveyed()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(VistaLocation), Member = "RemoveFromMap")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowVistaNotification")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationRequiredGearItem")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(VistaLocation), Member = "RemoveFromMap")]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CalledBy(Type = typeof(VistaLocation), Member = "OnDestroy")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(VistaLocation), Member = "OnTriggerExit")]
	private void RemoveFromMap()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(VistaLocation), Member = "Surveyed")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Map), Member = "AreAnyUnsurveyedVistasActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowVistaNotification")]
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
