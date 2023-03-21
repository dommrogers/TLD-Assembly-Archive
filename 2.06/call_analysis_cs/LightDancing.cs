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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "get_insideUnitCircle")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Light), Member = "set_shadowStrength")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 46)]
	[CallsUnknownMethods(Count = 38)]
	private void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	public LightDancing()
	{
	}
}
