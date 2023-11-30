using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class camera : MonoBehaviour
{
     [Range(0, 1)]
    [SerializeField] private float DefaultRotationStrength = 0.15f;
    [SerializeField] private float DefaultPositionStrength = 2f;
    [SerializeField] private float DefaultDuration = 0.5f;


    private void OnTriggerEnter(Collider other){
        if (other.tag == "ville")
        {
            Shake(DefaultDuration, DefaultPositionStrength, DefaultRotationStrength);
        }

    }


    public void Shake(float duration, float positionOffsetStrength, float rotationOffsetStrength)
    {
        StopAllCoroutines();
        StartCoroutine(CameraShakeCoroutine(duration, positionOffsetStrength, rotationOffsetStrength));
    }

    private IEnumerator CameraShakeCoroutine(float duration, float positionOffsetStrength, float rotationOffsetStrength)
    {
        float elapsed = 0f;
        float currentMagnitude = 1f;

        while (elapsed < duration)
        {
            float x = (Random.value - 0.5f) * currentMagnitude * positionOffsetStrength;
            float y = (Random.value - 0.5f) * currentMagnitude * positionOffsetStrength;

            float lerpAmount = currentMagnitude * rotationOffsetStrength;
            Vector3 lookAtVector = Vector3.Lerp(Vector3.forward, Random.insideUnitCircle, lerpAmount);

            transform.localPosition = new Vector3(x, y, 0);
            transform.localRotation = Quaternion.LookRotation(lookAtVector);

            elapsed += Time.deltaTime;
            currentMagnitude = (1 - (elapsed / duration)) * (1 - (elapsed / duration));

            yield return null;
        }

        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }
}
