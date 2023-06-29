using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.UI;

public class MiniTopNav : MonoBehaviour
{
	private Panel_Base m_PanelOwner;

	private List<MiniTopNavButton> m_NavElements;

	private float m_NavElementSize;

	private float m_NavElementStart;

	private GameObject m_HighlightSprite;

	private GameObject m_Controller;

	private GameObject m_SpriteLT;

	private GameObject m_SpriteRT;

	private ButtonLegendContainer m_ButtonLegendContainer;

	private GamepadButtonSprite[] m_GamepadButtonSprites;

	public Action m_ControllerPreviousOverride;

	private List<MiniTopNavButton> m_ActiveElements;

	private MonoBehaviour m_ParentContext;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "HandleMiniTopNavPrevious")]
	[CalledBy(Type = typeof(MiniTopNav), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(MiniTopNavButton), Member = "OnButtonClick")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void OnButtonClickPrevious()
	{
	}

	[CalledBy(Type = typeof(MiniTopNav), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(MiniTopNavButton), Member = "OnButtonClick")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void OnButtonClickNext()
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_RecipeBook), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_RecipeBook), Member = "EnableNavigationTabs")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(MiniTopNav), Member = "SpriteEnable")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PanelReference), Member = "TryGetPanel")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(MiniTopNavButton), Member = "SetEnabled")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 31)]
	public void Show(MonoBehaviour parentContext)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoMainNavControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Map), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "EnableNavigationTabs")]
	[CalledBy(Type = typeof(Panel_RecipeBook), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_RecipeBook), Member = "DisableFromCooking")]
	[CalledBy(Type = typeof(Panel_RecipeBook), Member = "EnableNavigationTabs")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Hide()
	{
	}

	[CalledBy(Type = typeof(MiniTopNav), Member = "Show")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 1)]
	private void SpriteEnable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(GamepadButtonSprite), Member = "UpdateSpriteForActiveController")]
	[Calls(Type = typeof(InputManager), Member = "GetAltFirePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetFirePressed")]
	[Calls(Type = typeof(MiniTopNav), Member = "OnButtonClickNext")]
	[Calls(Type = typeof(MiniTopNav), Member = "OnButtonClickPrevious")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public MiniTopNav()
	{
	}
}
