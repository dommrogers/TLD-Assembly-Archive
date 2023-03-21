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

	[CalledBy(Type = typeof(TextInputField), Member = "SetText")]
	[CalledBy(Type = typeof(TextInputField), Member = "GetText")]
	[CalledBy(Type = typeof(TextInputField), Member = "Select")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CallbackDispatcher), Member = "Unregister")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(string), Member = "Insert")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "UpdateLabel")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(TextInputField), Member = "SetText")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 35)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "SetupInputField")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetMaxLength(uint length)
	{
	}

	[CalledBy(Type = typeof(TextInputField), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateNotesPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RefreshRockCacheListForSelectedRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheItemClicked")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TextInputField), Member = "Start")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[Calls(Type = typeof(UIInput), Member = "set_defaultText")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SetText(string textToSet)
	{
	}

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TextInputField), Member = "Start")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string GetText()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsRockCaches")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsLockedIn()
	{
		return false;
	}

	[CalledBy(Type = typeof(RockCache), Member = "OnLabel")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowCurrentConfirmation")]
	[CalledBy(Type = typeof(Panel_Confirmation), Member = "ShowRenamePanel")]
	[CalledBy(Type = typeof(Panel_CustomXPSetup), Member = "OnEnterCode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "NoteTakingStart")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnRockCacheRenameButton")]
	[CalledBy(Type = typeof(Panel_Log), Member = "RockCacheNoteTakingStart")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "ShowNameSaveSlotPopup")]
	[CalledBy(Type = typeof(Panel_SaveStory), Member = "OnNewSave")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(TextInputField), Member = "Start")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(UIInput), Member = "set_defaultText")]
	[Calls(Type = typeof(SteamManager), Member = "get_Initialized")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Callback<>), Member = "Create")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(SteamUtils), Member = "ShowGamepadTextInput")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public void Select()
	{
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "CheckForNotesChange")]
	[CalledBy(Type = typeof(Panel_Log), Member = "MaybeUpdateRockCacheNoteView")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UILabel), Member = "UpdateNGUIText")]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(NGUIText), Member = "PrintExactCharacterPositions")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(UILabel), Member = "get_fontSize")]
	[Calls(Type = typeof(UIInput), Member = "get_isSelected")]
	[Calls(Type = typeof(UIInput), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 44)]
	public Vector3 GetCursorLocation()
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteropHelp), Member = "TestIfAvailableClient")]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal")]
	[Calls(TypeFullName = "Steamworks.NativeMethods", Member = "ISteamUtils_GetEnteredGamepadTextInput")]
	[Calls(Type = typeof(InteropHelp), Member = "PtrToStringUTF8")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void OnSteamKeyboardCallback(GamepadTextInputDismissed_t callbackData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UIInput), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void ConsoleKeyboardCallback(bool success, string desiredString)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public TextInputField()
	{
	}
}
