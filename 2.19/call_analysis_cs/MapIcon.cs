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
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UILabel), Member = "ProcessText")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[Calls(Type = typeof(Panel_Map), Member = "GetDetailLevelAlpha")]
	[Calls(Type = typeof(MapIcon), Member = "ScaleSprite")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 12)]
	private void LateUpdate()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Map), Member = "LoadMapElementsForScene")]
	[CallerCount(Count = 3)]
	public void DoSetup(MapElementSaveData mapData, Transform parentToUse, int index, MapIconType iconType, float mainSpriteSizeMultiplier, bool useSelectedBG)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void EnableDirectionalIcon(float angle)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsUnknownMethods(Count = 1)]
	public void ShowHoverWidget()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "SetMapIconBeingHovered")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void HideHoverWidget()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MapIcon), Member = "SetSpriteActive")]
	public State SetState(State state)
	{
		return default(State);
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "MergeNearbyMissionMapIconsWithLocations")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public string SetLocationMapIcon(MapIcon icon)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "UpdateIconsForOffscreenMissionMarkers")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public Transform GetLocationMapTransform()
	{
		return null;
	}

	[CalledBy(Type = typeof(MapIcon), Member = "EnableDirectionalIcon")]
	[CalledBy(Type = typeof(MapIcon), Member = "SetState")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void SetSpriteActive(UISprite sprite, bool isActive)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[CallsUnknownMethods(Count = 1)]
	private void SetDepths(int index)
	{
	}

	[CallerCount(Count = 0)]
	private int GetBaseDepth()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	private void TintSprite(UISprite sprite, Color tint)
	{
	}

	[CalledBy(Type = typeof(MapIcon), Member = "LateUpdate")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ScaleSprite(UISprite sprite, float scale)
	{
	}

	[CallerCount(Count = 0)]
	public MapIcon()
	{
	}
}
