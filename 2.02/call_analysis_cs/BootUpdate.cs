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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetPressAnyKeyString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetPressAnyKeyString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "CheckForActiveController")]
	[Calls(Type = typeof(Input), Member = "ResetInputAxes")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SceneManager), Member = "LoadSceneAsync")]
	[CallsDeduplicatedMethods(Count = 1)]
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
