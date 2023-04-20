using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class EpicOnlineServicesManager : MonoBehaviour
{
	public static string REFRESH_TOKEN_ARG;

	public string m_ProductName;

	public string m_ProductVersion;

	public string m_ProductId;

	public string m_SandboxId;

	public string m_DeploymentId;

	public string m_ClientId;

	public string m_ClientSecret;

	public string m_CatalogItemID;

	[CallerCount(Count = 0)]
	public EpicOnlineServicesManager()
	{
	}
}
