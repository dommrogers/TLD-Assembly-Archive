using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using Steamworks;
using UnityEngine;

public class TextInputField : MonoBehaviour
{
	public static bool m_IsShowingVirtualKeyboard;

	public static bool m_VirtualKeyboardDismissed;

	public string m_VirtualKeyboardDescriptionLocID;

	public uint m_MaxLength;

	public bool m_AllowBlankText;

	public bool m_AllowMultiLine;

	private BoxCollider m_Collider;

	private UILabel m_Label;

	private UIInput m_Input;

	private bool m_GamePadTextInputCallbackRegistered;

	private Callback<GamepadTextInputDismissed_t> m_OnSteamKeyboardCallback;

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(TextInputField), Member = "SetText")]
	[CalledBy(Type = typeof(TextInputField), Member = "GetText")]
	[CalledBy(Type = typeof(TextInputField), Member = "Select")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void SetMaxLength(uint length)
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CalledBy(Type = typeof(TextInputField), Member = "Update")]
	[Calls(Type = typeof(UIInput), Member = "set_defaultText")]
	[Calls(Type = typeof(TextInputField), Member = "Start")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	public void SetText(string textToSet)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(TextInputField), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public string GetText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	public bool IsLockedIn()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(RockCache), Member = "OnLabel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(UIInput), Member = "set_defaultText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(TextInputField), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(SteamUtils), Member = "ShowGamepadTextInput")]
	public void Select()
	{
	}

	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CallsUnknownMethods(Count = 44)]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	public Vector3 GetCursorLocation()
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(InteropHelp), Member = "PtrToStringUTF8")]
	[Calls(Type = typeof(Steamworks.NativeMethods), Member = "ISteamUtils_GetEnteredGamepadTextInput")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	private void OnSteamKeyboardCallback(GamepadTextInputDismissed_t callbackData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CallsUnknownMethods(Count = 1)]
	private void ConsoleKeyboardCallback(bool success, string desiredString)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TextInputField()
	{
	}
}
