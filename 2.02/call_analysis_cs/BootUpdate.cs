using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BootUpdate : MonoBehaviour
{
	public UILabel m_Label_Continue;

	public GameObject m_WiseAudioPrefab;

	private AsyncOperation m_AsyncOperation;

	private bool m_WaitingForSignedInUser;

	private static bool m_HasInitializedSystems;

	private AsyncOperation m_AsyncOp;

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetPressAnyKeyString")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Start()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Utils), Member = "GetPressAnyKeyString")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Input), Member = "ResetInputAxes")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	private void LoadMainMenu()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public BootUpdate()
	{
	}
}
