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

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[Calls(Type = typeof(Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	public void AssignValuesToSpawnedObject()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public GenericStatusBarSpawner()
	{
	}
}
