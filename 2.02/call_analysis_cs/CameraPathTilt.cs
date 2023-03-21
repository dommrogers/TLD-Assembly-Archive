using Cpp2ILInjected.CallAnalysis;

public class CameraPathTilt : CameraPathPoint
{
	public float tilt;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPoint), Member = ".ctor")]
	public CameraPathTilt()
	{
	}
}
