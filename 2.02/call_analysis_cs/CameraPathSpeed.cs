using Cpp2ILInjected.CallAnalysis;

public class CameraPathSpeed : CameraPathPoint
{
	public float _speed;

	public float speed
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(CameraPathPoint), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CameraPathSpeed()
	{
	}
}
