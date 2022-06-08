using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsTest : MonoBehaviour
{
    public void PlayAd()
    {
        UnityAdsManager.Instance.ShowRegularAd(OnAdClosed);
    }

    public void PlayRewardedAd()
    {
        UnityAdsManager.Instance.ShowRewardedAd(OnRewardedAdClosed);
    }
    
    private void OnAdClosed(ShowResult result)
    {
        Debug.Log("Regular ad closed");
    }
    private void OnRewardedAdClosed(ShowResult result)
    {
        Debug.Log("Rewarded ad closed");
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("Ad Finished. reward player");
                break;
            case ShowResult.Skipped:
                Debug.Log("Ad skipped, no candy");
                break;
            case ShowResult.Failed:
                Debug.Log("Works on my machine");
                break;
        }
    }
}
