using UnityEngine;
namespace MocapRecorder
{
    class IKScript :  MonoBehaviour
    {
        public KeyCode ResetOrientationKey = KeyCode.R;
        public GameObject[] Trackers;

        private void Update()
        {
            if(Input.GetKeyDown(ResetOrientationKey))
            {
                foreach(GameObject tracker in Trackers)
                {
                    // Reset transform for each tracker
                    var parentRot = tracker.transform.parent.rotation;
                    parentRot = Quaternion.Inverse(parentRot);
                    tracker.transform.rotation = parentRot;
                }
                Debug.Log("Resetting orientation");

            }
        }

    }
}
