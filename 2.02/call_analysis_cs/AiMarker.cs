using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AiMarker : MonoBehaviour
{
	public enum ObjectType
	{
		RifleRack,
		Chair
	}

	public string m_AttachToJointName;

	public GameObject m_Prop;

	public ObjectType m_ObjectType;

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AiMarker()
	{
	}
}
