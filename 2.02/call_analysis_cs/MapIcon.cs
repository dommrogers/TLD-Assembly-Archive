using Cpp2ILInjected.CallAnalysis;
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

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Panel_Map), Member = "GetDetailLevelAlpha")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallerCount(Count = 6)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	public void DoSetup(MapElementSaveData mapData, Transform parentToUse, int index, MapIconType iconType, float mainSpriteSizeMultiplier, bool useSelectedBG)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	public void EnableDirectionalIcon(float angle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsUnknownMethods(Count = 1)]
	public void ShowHoverWidget()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
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

	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconsForOffscreenMissionMarkers")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconsForOffscreenMissionMarkers")]
	public State SetState(State state)
	{
		return default(State);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Map), Member = "MergeNearbyMissionMapIconsWithLocations")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public string SetLocationMapIcon(MapIcon icon)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconsForOffscreenMissionMarkers")]
	[CallsUnknownMethods(Count = 3)]
	public Transform GetLocationMapTransform()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "EnableDirectionalIcon")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	private void SetSpriteActive(UISprite sprite, bool isActive)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void SetDepths(int index)
	{
	}

	[CallerCount(Count = 0)]
	private int GetBaseDepth()
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void TintSprite(UISprite sprite, Color tint)
	{
	}

	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	private void ScaleSprite(UISprite sprite, float scale)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MapIcon()
	{
	}
}
