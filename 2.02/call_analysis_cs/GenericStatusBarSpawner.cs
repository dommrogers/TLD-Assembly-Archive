using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GenericStatusBarSpawner : MonoBehaviour
{
	public GameObject m_Prefab;

	public StatusBar.StatusBarType m_StatusBarType;

	public float m_MediumThreshold;

	public float m_HighThreshold;

	public string m_MainSpriteName;

	public string m_EmptySpriteName;

	public bool m_IsOnHUD;

	public GameObject m_SpawnedObject;

	public StatusBar m_SpawnedStatusBar;

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[CallsUnknownMethods(Count = 18)]
	public void AssignValuesToSpawnedObject()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GenericStatusBarSpawner()
	{
	}
}
