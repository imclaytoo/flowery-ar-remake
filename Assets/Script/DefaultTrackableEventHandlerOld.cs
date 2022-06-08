/*==============================================================================
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;

namespace Vuforia
{
    /// <summary>
    /// A custom handler that implements the ITrackableEventHandler interface.
    /// </summary>
    public class DefaultTrackableEventHandlerOld : MonoBehaviour,
                                                ITrackableEventHandler
    {
        #region PRIVATE_MEMBER_VARIABLES
 
        private TrackableBehaviour mTrackableBehaviour;
        public AudioSource aSource;
        public AudioClip aClip;
    
        #endregion // PRIVATE_MEMBER_VARIABLES



        #region UNTIY_MONOBEHAVIOUR_METHODS
    
        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        #endregion // UNTIY_MONOBEHAVIOUR_METHODS



        #region PUBLIC_METHODS

        /// <summary>
        /// Implementation of the ITrackableEventHandler function called when the
        /// tracking state changes.
        /// </summary>
        public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus,TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                OnTrackingFound();
            }
            else
            {
                OnTrackingLost();
            }
        }

        #endregion // PUBLIC_METHODS



        #region PRIVATE_METHODS


        private void OnTrackingFound()
        {
           
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Enable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = true;
            }

            // Enable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = true;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");

            SystemConfig.instance.GUI_AR.SetActive(false);
            

            if (mTrackableBehaviour.TrackableName == "teratai")
            {
                aSource.PlayOneShot(aClip);
                InfoTeratai.instance.TombolInfo.SetActive(true);
            }
            if (mTrackableBehaviour.TrackableName == "sakura")
            {
                aSource.PlayOneShot(aClip);
                InfoSakura.instance.TombolInfo.SetActive(true);
            }
            if (mTrackableBehaviour.TrackableName == "matahari")
            {
                aSource.PlayOneShot(aClip);
                InfoMatahari.instance.TombolInfo.SetActive(true);
            }
            if (mTrackableBehaviour.TrackableName == "mawar")
            {
                aSource.PlayOneShot(aClip);
                InfoMawar.instance.TombolInfo.SetActive(true);
            }
            if (mTrackableBehaviour.TrackableName == "melati")
            {
                aSource.PlayOneShot(aClip);
                InfoMelati.instance.TombolInfo.SetActive(true);
            }
            if (mTrackableBehaviour.TrackableName == "lili")
            {
                aSource.PlayOneShot(aClip);
                InfoBakung.instance.TombolInfo.SetActive(true);
            }
            if (mTrackableBehaviour.TrackableName == "anggrek")
            {
                aSource.PlayOneShot(aClip);
                InfoAnggrek.instance.TombolInfo.SetActive(true);
            }
        }


        private void OnTrackingLost()
        {
            Renderer[] rendererComponents = GetComponentsInChildren<Renderer>(true);
            Collider[] colliderComponents = GetComponentsInChildren<Collider>(true);

            // Disable rendering:
            foreach (Renderer component in rendererComponents)
            {
                component.enabled = false;
            }

            // Disable colliders:
            foreach (Collider component in colliderComponents)
            {
                component.enabled = false;
            }

            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");

            SystemConfig.instance.GUI_AR.SetActive(true);

            if (mTrackableBehaviour.TrackableName == "teratai")
            {
                aSource.Stop();
                InfoTeratai.instance.TombolInfo.SetActive(false);
            }
            if (mTrackableBehaviour.TrackableName == "sakura")
            {
                aSource.Stop();
                InfoSakura.instance.TombolInfo.SetActive(false);
            }
            if (mTrackableBehaviour.TrackableName == "matahari")
            {
                aSource.Stop();
                InfoMatahari.instance.TombolInfo.SetActive(false);
            }
            if (mTrackableBehaviour.TrackableName == "mawar")
            {
                aSource.Stop();
                InfoMawar.instance.TombolInfo.SetActive(false);
            }
            if (mTrackableBehaviour.TrackableName == "melati")
            {
                aSource.Stop();
                InfoMelati.instance.TombolInfo.SetActive(false);
            }
            if (mTrackableBehaviour.TrackableName == "lili")
            {
                aSource.Stop();
                InfoBakung.instance.TombolInfo.SetActive(false);
            }
            if (mTrackableBehaviour.TrackableName == "anggrek")
            {
                aSource.Stop();
                InfoAnggrek.instance.TombolInfo.SetActive(false);
            }
        }
        

        #endregion // PRIVATE_METHODS
    }
}
