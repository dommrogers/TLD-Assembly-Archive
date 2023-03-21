using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightDancing : MonoBehaviour
{
	public enum movementShape
	{
		SPHERE,
		CUBE,
		CONE
	}

	public float sphereRadius;

	public Vector2 cube_xMinMax;

	public Vector2 cube_yMinMax;

	public Vector2 cube_zMinMax;

	public float coneHeight;

	public float coneRadius;

	public float shiftRate;

	public float shadowRate;

	public bool fadeShadows;

	public movementShape moveShape;

	private Vector3 originalPosition;

	private float shiftTimer;

	private float shadowTimer;

	private Vector3 srcPos;

	private Vector3 dstPos;

	private Light m_MyLight;

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Light), Member = "set_shadowStrength")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "get_insideUnitCircle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[Calls(Type = typeof(Gizmos), Member = "DrawRay")]
	[Calls(Type = typeof(Gizmos), Member = "DrawRay")]
	[Calls(Type = typeof(Gizmos), Member = "DrawRay")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(Gizmos), Member = "DrawRay")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 39)]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_left")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_left")]
	private void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LightDancing()
	{
	}
}
