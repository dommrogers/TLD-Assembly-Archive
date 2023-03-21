using System;
using Cpp2ILInjected.CallAnalysis;
using SpecialEvents;
using UnityEngine;

public class Panel_SprayPaint : Panel_Base
{
	[Serializable]
	public struct ShapeInfo
	{
		public ProjectileType ProjectileType;

		public LocalizedString m_Label;

		public Texture m_ShapeIcon;

		public bool m_AddedToMap;

		public bool m_OnlyAllowedOneOfType;
	}

	public class SprayPaintPanelSaveData
	{
		public ProjectileType m_LastSelectedShape;

		public bool m_CanShowBanishmentGlyph;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public SprayPaintPanelSaveData()
		{
		}
	}

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UILabel m_ShapeNotMappedMessage;

	public UILabel m_CannotPlaceMoreThanOneMessage;

	private ShapeInfo[] m_Shapes;

	private ShapeInfo[] m_NowhereToHideEventShapes;

	private GridUI m_ShapeGridUI;

	private ProjectileType m_LastSelectedShape;

	public GameObject[] m_MouseButtons;

	private GearItem m_SprayPaintCanToUse;

	private static SprayPaintPanelSaveData m_SprayPaintPanelSaveData;

	private bool m_CanShowBanishmentGlyph;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "ReturnToGame")]
	[CallsUnknownMethods(Count = 2)]
	public void OnButtonCancel()
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "UnlockDecalMapMarkersNearPosition")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnCompletedDecalPlaceDown")]
	[CalledBy(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	public bool CanPlaceDecalOnMap(ProjectileType projectile)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsValidSelection")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	public bool IsOnlyAllowedOneOfType(ProjectileType projectile)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdatePlaceDecal")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "AreAnyPlacedDecalsOfType")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InvisibleEntityManager), Member = "HasIndoorWardProtectionForCurrentScene")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsValidSelection")]
	public bool IsAlreadyPlacedInWorld(ProjectileType projectile)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	public bool DoesShapeLocIDExist(string locName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RemoveDecalFromMap")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RemoveDecalMapMarker")]
	[CalledBy(Type = typeof(Panel_Map), Member = "AddDecalMapMarker")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	public string GetShapeLocNameID(ProjectileType projectile)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsValidSelection")]
	[CallsUnknownMethods(Count = 3)]
	public ProjectileType GetSelectedDecalShape()
	{
		return default(ProjectileType);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnButtonConfirm()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "OnButtonCancel")]
	[Calls(Type = typeof(PlayerManager), Member = "StartPlaceDecal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void ReturnToGame()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "Scroll")]
	[CallsUnknownMethods(Count = 1)]
	public void OnButtonScrollLeft()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "Scroll")]
	[CallsUnknownMethods(Count = 1)]
	public void OnButtonScrollRight()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsUnknownMethods(Count = 1)]
	public void Reset()
	{
	}

	[Calls(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessReloadAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseSprayPaintCan")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteReloadAction")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "OnSprayPaint")]
	[CalledBy(Type = typeof(SprayPaintCan), Member = "OnWield")]
	[CalledBy(Type = typeof(GearItem), Member = "OnWield")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "ReturnToGame")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(GridUI), Member = "AddItem")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(GridUI), Member = "Initialize")]
	[Calls(Type = typeof(DynamicDecalsManager), Member = "RemoveDynamicDecal")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(EquipItemPopup), Member = "ShowPlaceMeshItem")]
	public void Enable(bool enable, GearItem sprayPaintCan, bool bypassScreen)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridUI), Member = "ClearItems")]
	[CallsUnknownMethods(Count = 1)]
	public void SetShowBanishmentGlyph(bool show)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool CanShowBanishmentGlyph()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "GetSelectedDecalShape")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	private bool IsValidSelection()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "GetShapes")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "GetSelectedDecalShape")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "DoesShapeLocIDExist")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[CalledBy(Type = typeof(Panel_Map), Member = "IsLocationIdSprayPaint")]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "GetShapeLocNameID")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "OnButtonCancel")]
	private bool IsUsingNowhereToHideShapes()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	private ShapeInfo[] GetShapes()
	{
		return null;
	}

	[Calls(Type = typeof(GridUI), Member = "RefreshTable")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "MaybeShowCannotPlaceMoreThanOneWarning")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "MaybeShowShapeWillNotShowOnMapWarning")]
	[Calls(Type = typeof(GridUI), Member = "UpdateControls")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	private void Update()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "CanPlaceDecalOnMap")]
	[Calls(Type = typeof(NowhereToHide), Member = "IsCurrentExperienceMode")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	private void MaybeShowShapeWillNotShowOnMapWarning(int selectedIndex)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_SprayPaint), Member = "Update")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsAlreadyPlacedInWorld")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsUsingNowhereToHideShapes")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_SprayPaint), Member = "IsOnlyAllowedOneOfType")]
	private void MaybeShowCannotPlaceMoreThanOneWarning(int selectedIndex)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateControls()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Panel_SprayPaint()
	{
	}
}
