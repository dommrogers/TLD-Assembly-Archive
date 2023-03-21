using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class ImpactDefinition : ScriptableObject
{
	public Vector3 m_PlayerDirection;

	public Vector3 m_CameraDirection;

	public float m_PlayerIntensity;

	public float m_CameraIntensity;

	public string m_AudioVO;

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Action_PlayerImpact), Member = "OnExecute")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(vp_Spring), Member = "AddForce")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	public void Apply()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ImpactDefinition()
	{
	}
}
