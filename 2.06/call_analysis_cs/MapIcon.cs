using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
using UnityEngine;

public class MapIcon : MonoBehaviour
{
	public enum MapIconType
	{
		TopIcon,
		DetailIcon,
		Text,
		DetailEntry,
		Area
	}

	public enum State
	{
		Uninitialized = -1,
		Default,
		Mission,
		Directional,
		Offscreen
	}

	private PanelReference<Panel_Map> m_Map;

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	public UISprite m_MainSprite;

	public UISprite m_BGSelectedSprite;

	public UISprite m_BGSprite;

	public UISprite m_Directional;

	public UISprite m_AreaZoneSprite;

	public UISprite m_OffscreenStationary;

	public UISprite m_OffscreenDirectional;

	public TweenAlpha m_LabelTween;

	public UILabel m_Label;

	public UISprite m_LabelBGSprite;

	public Vector2 m_LabelBGSpritePadding;

	public float m_SizeIncreaseOnSelect;

	public float m_SizeIncreaseTimeSeconds;

	public bool m_TextEntryScaleWithZoom;

	public UISprite m_MissionHighlight;

	public Color m_DefaultColour;

	public Color m_MainMissionColour;

	public Color m_SideMissionColour;

	private MapIcon m_LocationMapIcon;

	private MapIconType m_MapIconType;

	private State m_State;

	private bool m_IsHovering;

	private int m_DepthCached;

	private float m_SizeIncreaseCurrent;

	private float m_HoverTweenTimer;

	private string m_LocationNameLocID;

	private bool m_ShowDirection;

	private float m_MainSpriteSizeMultiplier;

	private bool m_HasBgSelectedSprite;

	private float m_OriginalBGSelectedAlpha;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Map), Member = "GetDetailLevelAlpha")]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "IsSideMission")]
	[Calls(Type = typeof(MapIcon), Member = "TintSprite")]
	[Calls(Type = typeof(MapIcon), Member = "TintSprite")]
	[Calls(Type = typeof(MapIcon), Member = "TintSprite")]
	[Calls(Type = typeof(MapIcon), Member = "TintSprite")]
	[Calls(Type = typeof(MapIcon), Member = "TintSprite")]
	[Calls(Type = typeof(MapIcon), Member = "TintSprite")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(MapIcon), Member = "EnableDirectionalIcon")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "TintSprite")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(MapIcon), Member = "HideHoverWidget")]
	[Calls(Type = typeof(MapIcon), Member = "SetDepths")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void DoSetup(MapElementSaveData mapData, Transform parentToUse, int index, MapIconType iconType, float mainSpriteSizeMultiplier, bool useSelectedBG)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 7)]
	public void EnableDirectionalIcon(float angle)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void ShowHoverWidget()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CallsUnknownMethods(Count = 2)]
	public void HideHoverWidget()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string GetLocationNameLocID()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public State GetState()
	{
		return default(State);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconsForOffscreenMissionMarkers")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconsForOffscreenMissionMarkers")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public State SetState(State state)
	{
		return default(State);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CalledBy(Type = typeof(Panel_Map), Member = "MergeNearbyMissionMapIconsWithLocations")]
	[CallsUnknownMethods(Count = 5)]
	public string SetLocationMapIcon(MapIcon icon)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconsForOffscreenMissionMarkers")]
	public Transform GetLocationMapTransform()
	{
		return null;
	}

	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CalledBy(Type = typeof(MapIcon), Member = "EnableDirectionalIcon")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void SetSpriteActive(UISprite sprite, bool isActive)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void SetDepths(int index)
	{
	}

	[CallerCount(Count = 0)]
	private int GetBaseDepth()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	[CalledBy(Type = typeof(MapIcon), Member = "DoSetup")]
	private void TintSprite(UISprite sprite, Color tint)
	{
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 3)]
	private void ScaleSprite(UISprite sprite, float scale)
	{
	}

	[CallerCount(Count = 0)]
	public MapIcon()
	{
	}
}
