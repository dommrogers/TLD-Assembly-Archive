using System.Globalization;
using System.IO;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FrameDumper : MonoBehaviour
{
	public Material m_CopyImageMaterial;

	public Material m_CopyDepthMaterial;

	public Material m_CopyNormalsMaterial;

	public static int m_CaptureMode;

	public static FrameDumper m_Instance;

	public static string m_AnimToCaptureNext;

	private static string m_ShotDirectory;

	private static bool m_Dumping;

	private static int m_CurrentImageIndex;

	private static int m_CaptureFramerate;

	private static float m_CaptureFarClip;

	private static FrameDumpHelper m_CaptureHelper;

	private static ThreadedImageWriter m_ImageWriter;

	private static Camera m_WeaponCamera;

	private static CameraClearFlags m_WeaponCameraClearFlags;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "Delete")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(FrameDumper), Member = "CreateHelpers")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void StartDumpingToDirectory(string directoryName)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_toggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(FrameDumper), Member = "CreateHelpers")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(FrameDumper), Member = "DestroyHelpers")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void Toggle()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FrameDumper), Member = "MaybeStartDumpingAnimation")]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Thread), Member = "Sleep")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetCaptureFramerate(int fps)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetCaptureFarClip(float farClip)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void SetCaptureMode(int mode)
	{
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "StartDumpingToDirectory")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Toggle")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	private void CreateHelpers()
	{
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "Toggle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void DestroyHelpers()
	{
	}

	[CalledBy(Type = typeof(FrameDumpHelper), Member = "OnRenderImage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(ImageConversion), Member = "EncodeToPNG")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 45)]
	public void DumpFrame(RenderTexture image, RenderTexture depth, RenderTexture norm)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void DumpFrameSimple()
	{
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "Update")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrameSimple")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static string GetImageFilename()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static string GetShotDirectory()
	{
		return null;
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorClipInfo")]
	[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 28)]
	private static void MaybeStartDumpingAnimation()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FrameDumper()
	{
	}
}
