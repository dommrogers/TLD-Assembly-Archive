using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class KeyRebindingButton : MonoBehaviour
{
	public UISprite m_SelectedSprite;

	public UILabel m_ValueLabel;

	public string m_ActionIDString;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	public void Start()
	{
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnKeyRebindButtonPress")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnGUI")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "UpdateKeyBindingTable")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "ConvertKeycodeToLabel")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 1)]
	public void SetValueLabel(string keycode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetSelected(bool selected)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public KeyRebindingButton()
	{
	}
}
