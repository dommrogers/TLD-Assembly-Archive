using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightShaftTod : MonoBehaviour
{
	public enum LightShaftDirection
	{
		NORTH,
		EAST,
		SOUTH,
		WEST,
		NONE
	}

	public bool followTod;

	public bool m_FadeWithViewAngle;

	public Vector2 yMinMax;

	public Vector2 zMinMax;

	public bool useXRotation;

	public LightShaftDirection facingDirection;

	public float m_MaximumIntensity;

	public Light m_Light;

	public GameObject[] m_LightShaft;

	public bool m_UseLightColour;

	private float m_ExternalIntensity;

	private float m_TodIntensity;

	private float yDirection;

	private float tod;

	private float xtemp;

	private float m_Dot;

	private float m_lValOrg;

	private Renderer[] m_LightShaftRenderer;

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(LightShaftTod), Member = "UpdateRotation")]
	[Calls(Type = typeof(LightShaftTod), Member = "UpdateMaterial")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_eulerAngles")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(LightShaftTod), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	private void UpdateRotation(float tod)
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(LightShaftTod), Member = "Update")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Light), Member = "get_color")]
	[Calls(Type = typeof(LightShaftTod), Member = "CalculateDot")]
	[Calls(Type = typeof(LightShaftTod), Member = "CalculateDot")]
	[Calls(Type = typeof(Light), Member = "get_intensity")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	private void UpdateMaterial()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateLight()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetExternalIntensity(float newIntensity)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetTimeOfDayIntensity(float todIntensity)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetFollowTimeOfDay(bool followTod)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(LightShaftTod), Member = "UpdateMaterial")]
	[CalledBy(Type = typeof(LightShaftTod), Member = "UpdateMaterial")]
	[CallsUnknownMethods(Count = 8)]
	private float CalculateDot()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
	{
		return default(float);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public LightShaftTod()
	{
	}
}
