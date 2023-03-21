using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class VistaLocation : MonoBehaviour
{
	[Serializable]
	public class MapDetailPoint
	{
		public Vector2 m_Position;

		public float m_Radius;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Map> m_Map;

	private ObjectGuid m_ObjectGuid;

	private const string PLAYER_COMPARE_TAG = "Player";

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public string GetGuid()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	public void Surveyed()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "ShouldAddSurveyPosition")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(VistaLocation), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool HasRequiredGearItem()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(VistaLocation), Member = "RemoveFromMap")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(VistaLocation), Member = "HasRequiredGearItem")]
	[Calls(Type = typeof(Panel_Map), Member = "GetMapNameOfCurrentScene")]
	[Calls(Type = typeof(Panel_Map), Member = "HasVistaLocationBeenSurveyed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowVistaNotification")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(VistaLocation), Member = "RemoveFromMap")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(VistaLocation), Member = "MaybeHideNotification")]
	[CalledBy(Type = typeof(VistaLocation), Member = "OnDestroy")]
	[CalledBy(Type = typeof(VistaLocation), Member = "OnTriggerExit")]
	[CallsUnknownMethods(Count = 1)]
	private void RemoveFromMap()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddSurveyedVistaLocation")]
	[CalledBy(Type = typeof(VistaLocation), Member = "RemoveFromMap")]
	[Calls(Type = typeof(Panel_Map), Member = "AreAnyUnsurveyedVistasActive")]
	[Calls(Type = typeof(Panel_HUD), Member = "ShowVistaNotification")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(VistaLocation), Member = "Surveyed")]
	private void MaybeHideNotification(Panel_Map map, Panel_HUD hud)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public VistaLocation()
	{
	}
}
