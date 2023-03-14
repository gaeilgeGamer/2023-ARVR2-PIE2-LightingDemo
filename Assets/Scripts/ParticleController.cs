using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ParticleController : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    private ParticleSystem particleSystem;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        particleSystem = GetComponentInChildren<ParticleSystem>();
    }

    public void StartParticleSystem(XRBaseInteractor interactor)
    {
        particleSystem.Play();
    }

    public void StopParticleSystem(XRBaseInteractor interactor)
    {
        particleSystem.Stop();
    }
}

